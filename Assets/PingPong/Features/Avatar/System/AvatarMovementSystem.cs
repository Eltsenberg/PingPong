using ME.ECS;
using PingPong.Components;
using UnityEngine;

namespace PingPong.Features.Avatar.System
{
#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
#endif
    public sealed class AvatarMovementSystem : ISystemFilter
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
            return Filter.Create("Filter-AvatarMovementSystem")
                .With<AvatarTag>()
                .WithoutShared<GamePaused>()
                .Push();
        }

        // ReSharper disable Unity.PerformanceAnalysis
        void ISystemFilter.AdvanceTick(in Entity entity, in float deltaTime)
        {
            ref readonly float speed = ref entity.Read<Speed>().Value;
            ref readonly int ID = ref entity.Read<Owner>().Value.Read<PlayerID>().Value;
            Vector3 inputEntityPosition = entity.GetLocalPosition();
            Vector3 outputEntityPosition = new Vector3(
                Mathf.Clamp(inputEntityPosition.x, -7, 7), inputEntityPosition.y, inputEntityPosition.z
            );

            float inputDirection = ID == 1 ? 1 : -1;
            ref float outputDirection = ref entity.Get<othDirection>().Value;
            Vector3 inversionDirection = new Vector3(outputDirection * inputDirection, 0, 0);
            Vector3 finalDirection = outputEntityPosition + inversionDirection * (speed * deltaTime);

            if (inputDirection == 0) return;
            entity.SetLocalPosition(finalDirection);
            
            //OLD
            /////////////////////////////////////////////////////////////////////////////////////////
            // ref readonly int id = ref entity.Read<Owner>().Value.Read<PlayerID>().Value;        //
            // if (id == PhotonNetwork.LocalPlayer.ActorNumber)                                    //
            // {                                                                                   //
            //     ref readonly float min = ref entity.Read<AvatarClampPosition>().Min;            //
            //     ref readonly float max = ref entity.Read<AvatarClampPosition>().Max;            //
            //     ref readonly Vector3 direction = ref entity.Get<Direction>().Value;             //
            //     ref readonly float speed = ref entity.Read<Speed>().Value;                      //
            //                                                                                     //
            //     float x = entity.GetPosition().x;                                               //
            //     Vector3 i = new Vector3(Mathf.Clamp(x, min, max), 0, entity.GetPosition().z);   //
            //     Vector3 newPosition = i + direction * speed;                                    //
            //                                                                                     //
            //     entity.SetPosition(newPosition);                                                //
            // }                                                                                   //
            /////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}