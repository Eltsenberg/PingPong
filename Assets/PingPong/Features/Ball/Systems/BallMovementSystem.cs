using ME.ECS;
using PingPong.Components;
using UnityEngine;

namespace PingPong.Features.Ball.Systems {

    
    #if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
    #endif
    public sealed class BallMovementSystem : ISystemFilter
    {
        
        private BallFeature feature;
        private Filter _filter;
        
        public World world { get; set; }
        
        void ISystemBase.OnConstruct() 
        {
            this.GetFeature(out this.feature);    
        }
        
        void ISystemBase.OnDeconstruct() {}
        
        #if !CSHARP_8_OR_NEWER
        bool ISystemFilter.jobs => true;
        int ISystemFilter.jobsBatchCount => 64;
        #endif
        Filter ISystemFilter.filter { get; set; }
        Filter ISystemFilter.CreateFilter() 
        {
            _filter = Filter.Create("Filter-BallMovementSystem")
            .With<Components.Ball>()
            .With<Direction>()
            .With<Speed>()
            .Push(); 
            return _filter;
        }
    
        void ISystemFilter.AdvanceTick(in Entity entity, in float deltaTime) 
        {
            ref readonly Vector3 direction = ref entity.Read<Direction>().Value;
            ref readonly float speed = ref entity.Read<Speed>().Value;

            Vector3 newPosition = entity.GetPosition() + direction * (speed * deltaTime);
            entity.SetPosition(newPosition);

        }    
    }

}