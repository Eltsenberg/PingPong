namespace ME.ECS {

    public static partial class ComponentsInitializer {

        static partial void InitTypeIdPartial() {

            WorldUtilities.ResetTypeIds();

            CoreComponentsInitializer.InitTypeId();


            WorldUtilities.InitComponentTypeId<PingPong.Components.AvatarClampPosition>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.AvatarSpawnPosition>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.AvatarTag>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Ball>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.BallAvatar>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.BallLaunched>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.DefaultPosition>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.DefaultScale>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Despawn>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Direction>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.GamePaused>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.HalfTime>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.IsAlive>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.IsNeutral>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.MonoView>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.NeedScore>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Normal>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.OnCollisionRect>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.othDirection>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Owner>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.PlayerAvatar>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.PlayerCount>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.PlayerID>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.PlayerScore>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.PlayGameTimer>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Radius>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.RectBox>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.RestartGame>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.RunGame>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.ScoreWall>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Speed>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Start>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.TimeLaunch>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Timer>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.TimerDefault>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.TimeSpawnBall>(false, true, false, false, false, false, false, false);

        }

        static partial void Init(ref ME.ECS.StructComponentsContainer structComponentsContainer, ref ME.ECS.StructComponentsContainer noStateStructComponentsContainer) {

            WorldUtilities.ResetTypeIds();

            CoreComponentsInitializer.InitTypeId();


            WorldUtilities.InitComponentTypeId<PingPong.Components.AvatarClampPosition>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.AvatarSpawnPosition>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.AvatarTag>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Ball>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.BallAvatar>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.BallLaunched>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.DefaultPosition>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.DefaultScale>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Despawn>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Direction>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.GamePaused>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.HalfTime>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.IsAlive>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.IsNeutral>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.MonoView>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.NeedScore>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Normal>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.OnCollisionRect>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.othDirection>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Owner>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.PlayerAvatar>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.PlayerCount>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.PlayerID>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.PlayerScore>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.PlayGameTimer>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Radius>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.RectBox>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.RestartGame>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.RunGame>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.ScoreWall>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Speed>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Start>(true, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.TimeLaunch>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.Timer>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.TimerDefault>(false, true, false, false, false, false, false, false);
            WorldUtilities.InitComponentTypeId<PingPong.Components.TimeSpawnBall>(false, true, false, false, false, false, false, false);

            ComponentsInitializerWorld.Setup(ComponentsInitializerWorldGen.Init);
            CoreComponentsInitializer.Init(ref structComponentsContainer);


            structComponentsContainer.Validate<PingPong.Components.AvatarClampPosition>(false);
            structComponentsContainer.Validate<PingPong.Components.AvatarSpawnPosition>(false);
            structComponentsContainer.Validate<PingPong.Components.AvatarTag>(true);
            structComponentsContainer.Validate<PingPong.Components.Ball>(true);
            structComponentsContainer.Validate<PingPong.Components.BallAvatar>(true);
            structComponentsContainer.Validate<PingPong.Components.BallLaunched>(true);
            structComponentsContainer.Validate<PingPong.Components.DefaultPosition>(false);
            structComponentsContainer.Validate<PingPong.Components.DefaultScale>(false);
            structComponentsContainer.Validate<PingPong.Components.Despawn>(true);
            structComponentsContainer.Validate<PingPong.Components.Direction>(false);
            structComponentsContainer.Validate<PingPong.Components.GamePaused>(true);
            structComponentsContainer.Validate<PingPong.Components.HalfTime>(true);
            structComponentsContainer.Validate<PingPong.Components.IsAlive>(true);
            structComponentsContainer.Validate<PingPong.Components.IsNeutral>(true);
            structComponentsContainer.Validate<PingPong.Components.MonoView>(false);
            structComponentsContainer.Validate<PingPong.Components.NeedScore>(false);
            structComponentsContainer.Validate<PingPong.Components.Normal>(false);
            structComponentsContainer.Validate<PingPong.Components.OnCollisionRect>(true);
            structComponentsContainer.Validate<PingPong.Components.othDirection>(false);
            structComponentsContainer.Validate<PingPong.Components.Owner>(false);
            structComponentsContainer.Validate<PingPong.Components.PlayerAvatar>(true);
            structComponentsContainer.Validate<PingPong.Components.PlayerCount>(false);
            structComponentsContainer.Validate<PingPong.Components.PlayerID>(false);
            structComponentsContainer.Validate<PingPong.Components.PlayerScore>(false);
            structComponentsContainer.Validate<PingPong.Components.PlayGameTimer>(false);
            structComponentsContainer.Validate<PingPong.Components.Radius>(false);
            structComponentsContainer.Validate<PingPong.Components.RectBox>(false);
            structComponentsContainer.Validate<PingPong.Components.RestartGame>(true);
            structComponentsContainer.Validate<PingPong.Components.RunGame>(true);
            structComponentsContainer.Validate<PingPong.Components.ScoreWall>(false);
            structComponentsContainer.Validate<PingPong.Components.Speed>(false);
            structComponentsContainer.Validate<PingPong.Components.Start>(true);
            structComponentsContainer.Validate<PingPong.Components.TimeLaunch>(false);
            structComponentsContainer.Validate<PingPong.Components.Timer>(false);
            structComponentsContainer.Validate<PingPong.Components.TimerDefault>(false);
            structComponentsContainer.Validate<PingPong.Components.TimeSpawnBall>(false);

        }

    }

    public static class ComponentsInitializerWorldGen {

        public static void Init(Entity entity) {


            entity.ValidateData<PingPong.Components.AvatarClampPosition>(false);
            entity.ValidateData<PingPong.Components.AvatarSpawnPosition>(false);
            entity.ValidateData<PingPong.Components.AvatarTag>(true);
            entity.ValidateData<PingPong.Components.Ball>(true);
            entity.ValidateData<PingPong.Components.BallAvatar>(true);
            entity.ValidateData<PingPong.Components.BallLaunched>(true);
            entity.ValidateData<PingPong.Components.DefaultPosition>(false);
            entity.ValidateData<PingPong.Components.DefaultScale>(false);
            entity.ValidateData<PingPong.Components.Despawn>(true);
            entity.ValidateData<PingPong.Components.Direction>(false);
            entity.ValidateData<PingPong.Components.GamePaused>(true);
            entity.ValidateData<PingPong.Components.HalfTime>(true);
            entity.ValidateData<PingPong.Components.IsAlive>(true);
            entity.ValidateData<PingPong.Components.IsNeutral>(true);
            entity.ValidateData<PingPong.Components.MonoView>(false);
            entity.ValidateData<PingPong.Components.NeedScore>(false);
            entity.ValidateData<PingPong.Components.Normal>(false);
            entity.ValidateData<PingPong.Components.OnCollisionRect>(true);
            entity.ValidateData<PingPong.Components.othDirection>(false);
            entity.ValidateData<PingPong.Components.Owner>(false);
            entity.ValidateData<PingPong.Components.PlayerAvatar>(true);
            entity.ValidateData<PingPong.Components.PlayerCount>(false);
            entity.ValidateData<PingPong.Components.PlayerID>(false);
            entity.ValidateData<PingPong.Components.PlayerScore>(false);
            entity.ValidateData<PingPong.Components.PlayGameTimer>(false);
            entity.ValidateData<PingPong.Components.Radius>(false);
            entity.ValidateData<PingPong.Components.RectBox>(false);
            entity.ValidateData<PingPong.Components.RestartGame>(true);
            entity.ValidateData<PingPong.Components.RunGame>(true);
            entity.ValidateData<PingPong.Components.ScoreWall>(false);
            entity.ValidateData<PingPong.Components.Speed>(false);
            entity.ValidateData<PingPong.Components.Start>(true);
            entity.ValidateData<PingPong.Components.TimeLaunch>(false);
            entity.ValidateData<PingPong.Components.Timer>(false);
            entity.ValidateData<PingPong.Components.TimerDefault>(false);
            entity.ValidateData<PingPong.Components.TimeSpawnBall>(false);

        }

    }

}
