using ME.ECS;

namespace PingPong.Features {

    using Modules;

#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
    #endif
    public sealed class UserInputFeature : Feature {

        protected override void OnConstruct()
        {
            AddModule<SendingInputModule>();
            AddSystem<ReceivingInputModule>();
        }

        protected override void OnDeconstruct() {}

    }

}