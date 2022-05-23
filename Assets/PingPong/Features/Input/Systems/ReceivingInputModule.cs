using System;
using ExitGames.Client.Photon.StructWrapping;
using ME.ECS;
using Photon.Pun;
using PingPong.Features.Avatar;
using PingPong.Markers.Local;
using PingPong.Markers.Network;
using UnityEngine;

namespace PingPong.Modules
{
    using Components;
    using Modules;
    using Systems;
    using Features;
    using Markers;

#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
#endif

    public sealed class ReceivingInputModule : ISystem, IUpdate
    {
        public World world { get; set; }
        private AvatarFeature feature;
        private RPCId rpcId_Movement,rpcId_GameState;

        void ISystemBase.OnConstruct()
        {
            this.GetFeature(out feature);
            NetworkModule networkModule = world.GetModule<NetworkModule>();
            networkModule.RegisterObject(this);

            rpcId_Movement = networkModule.RegisterRPC(new Action<DirectionInputButton>(Input_RPC).Method);
            rpcId_GameState = networkModule.RegisterRPC(new Action<NetworkRestartGame>(Restart_RPC).Method);
        }

        void ISystemBase.OnDeconstruct()
        {
        }

        // ReSharper disable Unity.PerformanceAnalysis
        void IUpdate.Update(in float deltaTime)
        {
            if (world.GetMarker(out DirectionInputButton directionMarker))
            {
                NetworkModule networkModule = world.GetModule<NetworkModule>();
                networkModule.RPC(this, rpcId_Movement, directionMarker);
            }

            if (world.GetMarker(out NetworkRestartGame restartMarker))
            {
                NetworkModule networkModule = world.GetModule<NetworkModule>();
                networkModule.RPC(this, rpcId_GameState, restartMarker);
            }
        }

        //
        private void Input_RPC(DirectionInputButton marker)
        {
            var player = feature.GetPlayerByID(marker.id);
            if (!player.IsAlive()) return;
            player.Get<PlayerAvatar>().Value.Get<othDirection>().Value = marker.dir;
        }
        private void Restart_RPC(NetworkRestartGame marker)
        {
            Debug.Log(true);
            world.SetSharedData(new IsAlive());
        }
    }
}