using ME.ECS;
using ME.ECS.Views.Providers;
using UnityEngine;

namespace PingPong.Components
{
    #region CORE
    public struct Direction : IComponent
    {
        public Vector3 Value;
    }

    public struct othDirection : IComponent
    {
        public float Value;
    }
    public struct DefaultPosition : IComponent
    {
        public Vector3 Value;
    }
    public struct Speed : IComponent
    {
        public float Value;
    }
    public struct DefaultScale : IComponent
    {
        public Vector3 Value;
    }

    public struct PlayerCount : IComponent
    {
        public int Value;
    }

    public struct NeedScore : IComponent
    {
        public int Value;
    }
    #endregion

    #region PLAYER
    public struct AvatarTag : IComponent {}
    public struct IsNeutral : IComponent {}
    public struct PlayerAvatar : IComponent
    {
        internal Entity Value;
    }

    public struct AvatarClampPosition : IComponent
    {
        public float Min;
        public float Max;
    }

    public struct AvatarSpawnPosition : IComponent
    {
        public Vector3 Player1;
        public Vector3 Player2;
    }
    public struct PlayerID : IComponent
    {
        public int Value;
    }
    public struct PlayerScore : IComponent
    {
        public int Value;
    }
    #endregion

    #region MECHANICS

    public struct OnCollisionRect : IComponent {}

    public struct RectBox : IComponent
    {
        public Vector3 Value;
    }
    public struct Normal : IComponent
    {
        public Vector3 Value;
    }
    public struct Timer : IComponent
    {
        public float Value;
    }
    public struct ScoreWall : IComponent
    {
        public int Value;
    }
    #endregion

    #region Ball
    public struct BallLaunched : IComponent {}
    public struct Despawn : IComponent {}
    public struct Ball : IComponent {}
    public struct Radius : IComponent
    {
        public float Value;
    }
    public struct BallAvatar : IComponent
    {
        internal Entity Value;
    }
    public struct TimeSpawnBall : IComponent
    {
        public float Value;
    }
    public struct TimeLaunch : IComponent
    {
        public float Value;
    }
    #endregion
    
    #region VIEW

    public struct MonoView : IComponent
    {
        public MonoBehaviourView Value;
    }

    #endregion

    #region SHARED

    public struct GamePaused : IComponent {}
    public struct Start : IComponent {}
    public struct RunGame : IComponent {}
    public struct HalfTime : IComponent {}

    public struct IsAlive : IComponent {}
    //
    //
    public struct PlayGameTimer : IComponent
    {
        public float Value;
    }
    public struct Owner : IComponent
    {
        public Entity Value;
    }
    public struct TimerDefault : IComponent
    {
        public float Value;
    }

    public struct RestartGame : IComponent
    {}
    #endregion
}