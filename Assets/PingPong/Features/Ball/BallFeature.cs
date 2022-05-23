using ME.ECS;
using ME.ECS.DataConfigs;
using PingPong.Components;
using PingPong.Features.Avatar;
using PingPong.Features.Ball.Systems;
using UnityEngine;

namespace PingPong.Features.Ball
{
#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
#endif
    public sealed class BallFeature : Feature
    {
        public DataConfig data;
        public GlobalEvent @eventPlayerScore;
        private AvatarFeature feature;

        private readonly Vector3[] dir = new[]
        {
            new Vector3(1,0,1),
            new Vector3(-1,0,-1),
            new Vector3(1,0,-1),
            new Vector3(-1,0,1)
            
        };


        // ReSharper disable Unity.PerformanceAnalysis
        protected override void OnConstruct()
        {
            AddSystem<BallDespawnSystem>();
            AddSystem<BallMovementSystem>();
            AddSystem<BallSpawnSystem>();
            AddSystem<BallLaunchSystem>();
            //
            world.GetFeature(out feature);
        }

        protected override void OnDeconstruct()
        {
        }

        protected override void InjectFilter(ref FilterBuilder builder)
        {
            builder.WithoutShared<GamePaused>();
        }
        internal Entity CreateBall(string name)
        {
            Entity entity = new Entity(name);
            entity.Get<Owner>().Value = feature.GetPlayerByID(0);
            data.Apply(entity);
            entity.Get<Direction>().Value = dir[world.GetRandomRange(0,3)];
            //
            //
            ViewId view = world.RegisterViewSource(data.Read<MonoView>().Value);
            entity.SetLocalScale(data.Read<DefaultScale>().Value);
            entity.InstantiateView(view);
            return entity;
        }
    }
}