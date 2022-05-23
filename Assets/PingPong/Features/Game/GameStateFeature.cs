using ME.ECS;
using ME.ECS.DataConfigs;
using PingPong.Features.Game;
using PingPong.Features.Game.Systems;
using PingPong.Modules;

namespace PingPong.Features
{
#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
#endif
    public sealed class GameStateFeature : Feature
    {
        public GlobalEvent @eventGameReady;
        public GlobalEvent @eventEndGame;
        public GlobalEvent @eventRestartGame;
        public DataConfig data;
        protected override void OnConstruct()
        {
            AddSystem<EndGame>();
            AddSystem<StartGame>();
            AddSystem<RestartGameSystem>();
        }

        protected override void OnDeconstruct() {}
    }
}