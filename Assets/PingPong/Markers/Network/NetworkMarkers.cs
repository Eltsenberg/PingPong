using ME.ECS;

namespace PingPong.Markers.Network
{
    public struct NetworkSetActivePlayer : IMarker
    {
        public int ID;
    }

    public struct NetworkPlayerDisconnected : IMarker
    {
        public int ID;
    }

    public struct NetworkRestartGame : IMarker {}

    public struct NetworkPlayerConnectedTimeSynced : IMarker {}
}