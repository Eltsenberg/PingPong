using System;
using ME.ECS;
using PingPong.Components;
using PingPong.Features.Avatar;
using UnityEngine;
using UnityEngine.UI;

namespace PingPong.Mono
{
    public class ScoreUpdate : MonoBehaviour
    {
        public GlobalEvent @evetnTimeSynced;
        public GlobalEvent @eventPlayerScore;
        //
        public Text player1Score;
        public Text player2Score;
        //
        private Entity player1;
        private Entity player2;
        void Start()
        {
            evetnTimeSynced.Subscribe(SetPlayer);
            eventPlayerScore.Subscribe(UpdateScore);
        }

        private void SetPlayer(in Entity entity)
        {
            player1 = Worlds.current.GetFeature<AvatarFeature>().GetPlayerByID(1);
            player2 = Worlds.current.GetFeature<AvatarFeature>().GetPlayerByID(2);
        }

        private void UpdateScore(in Entity entity)
        {
            player1Score.text = player1.Read<PlayerScore>().Value.ToString();
            player2Score.text = player2.Read<PlayerScore>().Value.ToString();
        }

        private void OnDestroy()
        {
            evetnTimeSynced.Unsubscribe(SetPlayer);
            eventPlayerScore.Unsubscribe(UpdateScore);
        }
    }
}
