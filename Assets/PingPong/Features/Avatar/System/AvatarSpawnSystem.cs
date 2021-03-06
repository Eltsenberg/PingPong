using ME.ECS;
using PingPong.Components;

namespace PingPong.Features.Avatar.System
{
#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
#endif
    public sealed class AvatarSpawnSystem : ISystemFilter
    {
        private AvatarFeature feature;

        public World world { get; set; }

        void ISystemBase.OnConstruct()
        {
            this.GetFeature(out this.feature);
        }

        void ISystemBase.OnDeconstruct()
        {
        }

#if !CSHARP_8_OR_NEWER
        bool ISystemFilter.jobs => false;
        int ISystemFilter.jobsBatchCount => 64;
#endif
        Filter ISystemFilter.filter { get; set; }

        Filter ISystemFilter.CreateFilter()
        {
            return Filter.Create("Filter-AvatarSpawnSystem")
                .With<PlayerID>()
                .WithoutShared<GamePaused>()
                .Without<IsNeutral>()
                .Without<PlayerAvatar>()
                .Push();
        }

        void ISystemFilter.AdvanceTick(in Entity entity, in float deltaTime)
        {
            feature.CreatePlayerAvatar(entity);
        }
    }
}