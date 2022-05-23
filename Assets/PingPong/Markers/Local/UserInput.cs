using ME.ECS;
using UnityEngine;

namespace PingPong.Markers.Local {
    
    public struct DirectionInputButton : IMarker
    {
        public int id;
        public float dir;
    }
}