using ME.ECS;
using PingPong.Features.User;
using PingPong.Markers.Network;

namespace PingPong.Modules {
    
    
    #if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
    #endif
    public sealed class UserConnectedModule : IModule, IUpdate {
        
        public World world { get; set; }
        private UserInitializationFeature feature;

        void IModuleBase.OnConstruct()
        {
            world.GetFeature(out feature);
        }
        

        void IModuleBase.OnDeconstruct() {}

        void IUpdate.Update(in float deltaTime)
        {
            if (this.world.GetMarker(out NetworkSetActivePlayer connectedMarker))
            {
                feature.OnPlayerConnected(connectedMarker);
            }
            if (world.GetMarker(out NetworkPlayerConnectedTimeSynced timeSyncedMarker))
            {
                feature.OnTimeSynced();
            }
        }
    }
    
}
