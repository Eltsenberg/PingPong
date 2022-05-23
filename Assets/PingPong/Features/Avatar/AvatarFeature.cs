using ME.ECS;
using ME.ECS.DataConfigs;
using ME.ECS.Views.Providers;
using PingPong.Components;
using PingPong.Features.Avatar.System;
using UnityEngine;

namespace PingPong.Features.Avatar
{
#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
#endif
    public sealed class AvatarFeature : Feature
    {
        private Entity entity;
        private Filter filterPlayerByID;
        public GlobalEvent @eventPassPlayer;
        public DataConfig data;
        //
        //
        public MonoBehaviourViewBase player1view;
        public MonoBehaviourViewBase player2view;
        //
        private ViewId player1, player2;
        

        // ReSharper disable Unity.PerformanceAnalysis
        protected override void OnConstruct()
        {
            AddSystem<AvatarSpawnSystem>();
            AddSystem<AvatarMovementSystem>();
            Filter.Create("Player-Filter")
                .With<PlayerID>()
                .Push(ref filterPlayerByID);
            //
            player1 = world.RegisterViewSource(player1view);
            player2 = world.RegisterViewSource(player2view);
        }

        protected override void OnDeconstruct()
        {
        }

        // ReSharper disable Unity.PerformanceAnalysis
        internal void CreatePlayerAvatar(Entity owner)
        {
            entity = new Entity("Avatar");
            data.Apply(entity);
            entity.Get<Owner>().Value = owner;
            owner.Get<PlayerAvatar>().Value = entity;
            entity.SetPosition(entity.Read<Owner>().Value.Read<PlayerID>().Value == 1
                ? data.Read<AvatarSpawnPosition>().Player1
                : data.Read<AvatarSpawnPosition>().Player2);
            entity.SetLocalScale(data.Read<DefaultScale>().Value);
            entity.InstantiateView(owner.Read<PlayerID>().Value == 1 ? player1 : player2);
        }

        #region PLAYER_INFO

        internal Entity GetPlayerByID(int id)
        {
            foreach (var player in filterPlayerByID)
            {
                if (player.Read<PlayerID>().Value == id)
                {
                    return player;
                }
            }

            return Entity.Empty;
        }

        public void PassLocalPlayer()
        {
            foreach (var entity in filterPlayerByID)
            {
                @eventPassPlayer.Execute(entity);
            }
        }
        #endregion
    }
}