using ME.ECS;
using PingPong.Components;
using PingPong.Features.Avatar;

namespace PingPong.Features.Game.Systems {
    
    #if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
    #endif
    public sealed class StartGame : ISystemFilter {
        
        private GameStateFeature gameStateFeature;
        private AvatarFeature avatarFeature;
        
        public World world { get; set; }
        
        void ISystemBase.OnConstruct() {
            
            this.GetFeature(out this.gameStateFeature);
            world.GetFeature(out this.avatarFeature);
            
        }
        
        void ISystemBase.OnDeconstruct() {}
        
        #if !CSHARP_8_OR_NEWER
        bool ISystemFilter.jobs => false;
        int ISystemFilter.jobsBatchCount => 64;
        #endif
        Filter ISystemFilter.filter { get; set; }
        Filter ISystemFilter.CreateFilter() {
            
            return Filter.Create("Filter-StartGame")
                .With<PlayerID>()
                .With<IsNeutral>()
                .WithoutShared<GamePaused>()
                .Push();
            
        }

        // ReSharper disable Unity.PerformanceAnalysis
        void ISystemFilter.AdvanceTick(in Entity entity, in float deltaTime)
        {
            ref float time = ref entity.Get<PlayGameTimer>().Value;
            ref readonly float timeDefault = ref entity.Read<TimerDefault>().Value;
            time -= deltaTime;

            if (time <= timeDefault /2 && !entity.Has<HalfTime>())
            {
                avatarFeature.PassLocalPlayer();
                entity.Set(new HalfTime());
            }

            if (time <= 0)
            {
                gameStateFeature.eventGameReady.Execute();
                world.RemoveSharedData<GamePaused>();
                entity.Remove<HalfTime>();
            }
        }
    
    }
    
}