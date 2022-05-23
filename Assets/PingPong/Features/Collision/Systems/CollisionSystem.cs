using ME.ECS;
using PingPong.Components;
using UnityEngine;

// ReSharper disable All

namespace PingPong.Features.Collision.Systems
{
#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
#endif
    public sealed class CollisionSystem : ISystemFilter
    {
        private CollisionFeature feature;
        private Filter _collisionFilter;

        public World world { get; set; }

        void ISystemBase.OnConstruct()
        {
            this.GetFeature(out this.feature);
            Filter.Create("BallCollision")
                .With<Components.Ball>()
                .Push(ref _collisionFilter);
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
            return Filter.Create("Filter-CollisionSystem")
                .With<OnCollisionRect>()
                .Push();
        }

        void ISystemFilter.AdvanceTick(in Entity entity, in float deltaTime)
        {
            ref readonly Vector3 rect = ref entity.Read<RectBox>().Value;
            var position = entity.GetPosition();
            //
            foreach (var current in _collisionFilter)
            {
                ref readonly float rad = ref current.Read<Radius>().Value;
                Vector3 currPos = current.GetPosition();
                //
                ref readonly Vector3 normal = ref entity.Read<Normal>().Value;
                ref Vector3 dir = ref current.Get<Direction>().Value;
                ref float speed = ref current.Get<Speed>().Value;
                Vector3 vel = dir * (speed * deltaTime);
                //
                //
                //
                Vector3 box = new Vector3(
                    Mathf.Max(position.x - rect.x, Mathf.Min(position.x + rect.x, currPos.x)),
                    0,
                    Mathf.Max(position.z - rect.z, Mathf.Min(position.z + rect.z, currPos.z)));
                
                if ((box - (currPos + vel)).sqrMagnitude <= rad * rad)
                {
                    Vector3 pos = entity.GetPosition() - entity.Read<Direction>().Value
                        * (entity.GetPosition() - box).magnitude;
                
                    entity.SetPosition(pos);
                    dir = Vector3.Reflect(dir, normal);
                    speed += 0.1f;
                    //
                    //
                    if (entity.Has<Components.ScoreWall>())
                    {
                        current.Remove<Speed>();
                        current.Get<PlayerID>().Value = entity.Read<Components.ScoreWall>().Value;
                        current.Set<Despawn>();
                        return;
                    }
                }
            }
        }
    }
}