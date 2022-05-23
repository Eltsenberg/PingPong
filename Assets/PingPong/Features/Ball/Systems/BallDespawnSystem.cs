using ME.ECS;
using PingPong.Components;
using PingPong.Features.Avatar;

namespace PingPong.Features.Ball.Systems
{
#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
#endif
    public sealed class BallDespawnSystem : ISystemFilter
    {
        public World world { get; set; }
        
        private BallFeature _feature;
        private AvatarFeature _avatar;

        void ISystemBase.OnConstruct()
        {
            this.GetFeature(out _feature);
            world.GetFeature(out _avatar);
        }

        void ISystemBase.OnDeconstruct() {}
#if !CSHARP_8_OR_NEWER
        bool ISystemFilter.jobs => false;
        int ISystemFilter.jobsBatchCount => 64;
#endif
        Filter ISystemFilter.filter { get; set; }
        Filter ISystemFilter.CreateFilter()
        {
            return Filter.Create("Filter-BallDespawnSystem")
                .With<Components.Ball>()
                .With<Despawn>()
                .Push();
        }

        // ReSharper disable Unity.PerformanceAnalysis
        void ISystemFilter.AdvanceTick(in Entity entity, in float deltaTime)
        {
            var player = _avatar.GetPlayerByID(entity.Read<PlayerID>().Value);
            
            player.Get<Components.PlayerScore>().Value += 1;
            _feature.eventPlayerScore.Execute();

            entity.Get<Owner>().Value.Remove<BallAvatar>();
            entity.Get<Owner>().Value.Remove<BallLaunched>();
            entity.Destroy();
        }
    }
}