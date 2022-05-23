using ME.ECS;
using Photon.Pun;
using PingPong.Components;
using PingPong.Markers.Local;
using UnityEngine;
using PingPong.Markers.Network;

namespace PingPong.Modules
{
#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
#endif
    public sealed class SendingInputModule : IModule, IUpdate
    {
        public World world { get; set; }

        void IModuleBase.OnConstruct()
        {
        }


        void IModuleBase.OnDeconstruct()
        {
        }

        void IUpdate.Update(in float deltaTime)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) ||
                Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
                world.AddMarker(new DirectionInputButton()
                    { id = PhotonNetwork.LocalPlayer.ActorNumber, dir = Input.GetAxisRaw("Horizontal") });
            //
            if (Input.GetKeyDown(KeyCode.R) && world.HasSharedData<GamePaused>())
            {
                world.AddMarker(new NetworkRestartGame());
            }
        }
    }
}