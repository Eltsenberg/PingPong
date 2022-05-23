using ME.ECS;
using PingPong.Components;

namespace PingPong.Features.Ball.Systems
{
#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
#endif
    public sealed class BallLaunchSystem : ISystemFilter
    {
        public World world { get; set; }
        
        private BallFeature feature;

        void ISystemBase.OnConstruct()
        {
            this.GetFeature(out feature);
        }
        void ISystemBase.OnDeconstruct() {}
#if !CSHARP_8_OR_NEWER
        bool ISystemFilter.jobs => false;
        int ISystemFilter.jobsBatchCount => 64;
#endif
        Filter ISystemFilter.filter { get; set; }
        Filter ISystemFilter.CreateFilter()
        {
            return Filter.Create("Filter-BallLaunchSystem")
                .With<PlayerID>()
                .With<IsNeutral>()
                .With<BallAvatar>()
                .Without<BallLaunched>()
                .Push();
        }

        // ReSharper disable Unity.PerformanceAnalysis
        void ISystemFilter.AdvanceTick(in Entity entity, in float deltaTime)
        {
            ref float time = ref entity.Get<TimeLaunch>().Value;
            ref readonly float timeDefault = ref entity.Read<TimerDefault>().Value;
            ref readonly float defaultSpeed = ref entity.Read<Speed>().Value; 
            time -= deltaTime;

            if (time <= 0)
            {
                entity.Get<BallAvatar>().Value.Get<Speed>().Value = 4f;
                entity.Set(new BallLaunched());
                time = timeDefault;
            }
        }
    }
}