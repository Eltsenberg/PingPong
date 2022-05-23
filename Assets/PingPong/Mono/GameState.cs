using ME.ECS;
using Photon.Pun;
using PingPong.Components;
using PingPong.Features.Avatar;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public GlobalEvent @eventTimeSynced;
    public GlobalEvent @eventPassLocalPlayer;
    public GlobalEvent @eventRestartGame;
    public GlobalEvent @eventEndGame;
    public GameObject Image;
    public GameObject Camera;

    private void Start()
    {
        eventPassLocalPlayer.Subscribe(RotateCamera);
        eventTimeSynced.Subscribe(HideImage);
        eventEndGame.Subscribe(ShowImage);
        eventRestartGame.Subscribe(ShowImage);
    }


    private void HideImage(in Entity entity)
    {
        Image.SetActive(false);
    }

    private void ShowImage(in Entity entity)
    {
        if (Worlds.current.HasSharedData<GamePaused>())
            Image.SetActive(true);
    }


    private void RotateCamera(in Entity entity)
    {
        if (entity != Worlds.current.GetFeature<AvatarFeature>()
                .GetPlayerByID(PhotonNetwork.LocalPlayer.ActorNumber)) return;
        int ID = entity.Read<PlayerID>().Value;
        var p1 = Quaternion.Euler(90, 0, 180);
        var p2 = Quaternion.Euler(90, 0, 0);

        Camera.transform.rotation = ID == 2 ? p1 : p2;
    }

    private void OnDestroy()
    {
        eventTimeSynced.Unsubscribe(HideImage);
        eventTimeSynced.Subscribe(HideImage);
    }
}