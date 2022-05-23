using System;
using ME.ECS;
using ME.ECS.DataConfigs;
using PingPong.Components;
using PingPong.Features.Wall;
using PingPong.Markers.Network;
using PingPong.Modules;
using UnityEngine;

namespace PingPong.Features.User
{
#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
#endif
    public sealed class UserInitializationFeature : Feature
    {
        private WallFeature wallFeature;
        private Filter playerFilter;
        private RPCId onPlayerConnected, onTimeSynced;
        public GlobalEvent @eventTimeSynced;
        public DataConfig Data;

        // ReSharper disable Unity.PerformanceAnalysis
        protected override void OnConstruct()
        {
            AddModule<UserConnectedModule>();
            CreateNeutralPlayer();
            Filter.Create("Player-Filter")
                .With<PlayerID>()
                .Push(ref playerFilter);
            //
            var network = this.world.GetModule<NetworkModule>();
            network.RegisterObject(this);
            //
            onPlayerConnected =
                network.RegisterRPC(new Action<NetworkSetActivePlayer>(PlayerConnectedRPC).Method);
            onTimeSynced =
                network.RegisterRPC(new Action(TimeSyncedRPC).Method);
            //
            world.SetSharedData(new GamePaused());
            world.GetFeature(out wallFeature);
        }
        //
        protected override void OnDeconstruct() {}
        
        private void CreateNeutralPlayer()
        {
            var entity = new Entity("neutralPlayer");
            Data.Apply(entity);
        }

        #region EVENTS

        //ReSharper disable Unity.PerformanceAnalysis
        public void OnPlayerConnected(NetworkSetActivePlayer marker)
        {
            var network = this.world.GetModule<NetworkModule>();
            network.RPC(this, onPlayerConnected, marker);
        }
        //ReSharper disable Unity.PerformanceAnalysis
        public void OnTimeSynced()
        {
            var network = this.world.GetModule<NetworkModule>();
            network.RPC(this, onTimeSynced);
        }

        #endregion
        //
        #region RPC
        private void PlayerConnectedRPC(NetworkSetActivePlayer marker)
        {
            Entity entity = new Entity("Player");
            entity.Get<PlayerID>().Value = marker.ID;
            entity.Set<PlayerScore>();
            Debug.Log($"Connected with:{entity.Read<PlayerID>().Value}");
        }
        private void TimeSyncedRPC()
        {
            eventTimeSynced.Execute();
            world.RemoveSharedData<GamePaused>();
            wallFeature.wallCreate();
            Debug.Log($"Time Synced");
        }
        #endregion
    }
}