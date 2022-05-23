using ME.ECS;
using ME.ECS.DataConfigs;
using PingPong.Components;

namespace PingPong.Features.Wall
{
#if ECS_COMPILE_IL2CPP_OPTIONS
    [Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.NullChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false),
     Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
#endif
    public sealed class WallFeature : Feature
    {
        public DataConfig[] _data;

        protected override void OnConstruct()
        {

        }

        protected override void OnDeconstruct()
        {
        }

        internal void wallCreate()
        {
            foreach (var t in _data)
            {
                Entity entity = new Entity("Wall");
                t.Apply(entity);
                ViewId view = world.RegisterViewSource(t.Read<MonoView>().Value);
                entity.SetPosition(t.Read<DefaultPosition>().Value);
                entity.SetLocalScale(t.Read<DefaultScale>().Value);
                entity.InstantiateView(view);
            }
        }
    }
}