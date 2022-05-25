using ME.ECS;
using PingPong.Components;
using UnityEngine;

namespace PingPong.Features.Game.Systems {
    
    
    #if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
    #endif
    public sealed class EndGame : ISystemFilter {
        
        private GameStateFeature feature;
        private Filter filter;
        
        public World world { get; set; }
        
        void ISystemBase.OnConstruct() {
            
            this.GetFeature(out this.feature);
            Filter.Create("Ball-Filter")
                .With<Components.Ball>()
                .Push(ref filter);

        }
        void ISystemBase.OnDeconstruct() {}
        
        #if !CSHARP_8_OR_NEWER
        bool ISystemFilter.jobs => false;
        int ISystemFilter.jobsBatchCount => 64;
        #endif
        Filter ISystemFilter.filter { get; set; }
        Filter ISystemFilter.CreateFilter() {
            
            return Filter.Create("Filter-StartGame")
                .With<PlayerScore>()
                .WithoutShared<GamePaused>()
                .Push();
            
        }

        // ReSharper disable Unity.PerformanceAnalysis
        void ISystemFilter.AdvanceTick(in Entity entity, in float deltaTime)
        {
            ref readonly int score = ref entity.Read<PlayerScore>().Value;
            if (score >= 5)
            {
                feature.eventEndGame.Execute();
                world.SetSharedData(new GamePaused());
                // GamePaused => Stop AdvanceTick in this System
            }
        }
    
    }
}