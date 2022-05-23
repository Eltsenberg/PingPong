using ME.ECS;
using PingPong.Components;

namespace PingPong.Features.Game.Systems
{
#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
#endif
    public sealed class RestartGameSystem : ISystemFilter
    {
        private GameStateFeature feature;
        public World world { get; set; }

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
            return Filter.Create("Filter-StartGame")
                .With<PlayerScore>()
                .WithShared<IsAlive>()
                .WithShared<GamePaused>()
                .Push();
        }

        // ReSharper disable Unity.PerformanceAnalysis
        void ISystemFilter.AdvanceTick(in Entity entity, in float deltaTime)
        {
            entity.Get<PlayerScore>().Value = 0;
            feature.eventRestartGame.Execute();
            world.RemoveSharedData<GamePaused>();
            world.RemoveSharedData<IsAlive>();
        }
    }
}