using ME.ECS;
using PingPong.Components;
using UnityEngine;

namespace PingPong.Features.Ball.Systems
{
#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
#endif
    public sealed class BallSpawnSystem : ISystemFilter
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
            return Filter.Create("Filter-BallSpawnSystem")
                .With<PlayerID>()
                .With<IsNeutral>()
                .Without<BallAvatar>()
                .Push();
        }

        // ReSharper disable Unity.PerformanceAnalysis
        void ISystemFilter.AdvanceTick(in Entity entity, in float deltaTime)
        {
            ref var time = ref entity.Get<TimeSpawnBall>().Value;
            ref readonly var timeDefault = ref entity.Read<TimerDefault>().Value;
            time -= deltaTime;
            
            
            switch (time)
            {
                case <= 0:
                    entity.Get<BallAvatar>().Value = feature.CreateBall("Ball");
                    time = timeDefault;
                    break;
            }
        }
    }
}