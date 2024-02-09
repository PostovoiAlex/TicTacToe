using System;
using UnityEngine;

namespace TicTacToe
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] Player[] players;
        Player _currentPlayer;
        [SerializeField] Field _field;
        [SerializeField] Turn _turn;
        [SerializeField] WinCondition _winCondition;

        public Action OnGameEnded { get; set; }

        void Awake()
        {
            _field.Init();

            foreach (var player in players)
            {
                player.Init(_field);
            }
            
            _turn.Init(_field);
         
            _turn.OnTurnStarted += OnTurnStarted;
            _turn.OnTurnEnded += OnTurnEnded;
        }

        public void Start()
        {
            StartTurn();
        }

        void OnTurnEnded()
        {
            _currentPlayer.EndTurn();

            if(_winCondition.CheckCondition(_field.LastSelectedTile))
            {
                Debug.Log("Game Ended");
                OnGameEnded?.Invoke();
                return;
            }

            StartTurn();
        }
        
        void OnTurnStarted()
        {
            //throw new System.NotImplementedException();
        }

        void StartTurn()
        {
            Player nextPlayer = GetNextPlayer();

            _currentPlayer = nextPlayer;
            
            _currentPlayer.StartTurn();
            _turn.StartTurn();
        }
        
        Player GetNextPlayer()
        {
            int nextPlayerIndex = 0;
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i] == _currentPlayer)
                {
                    nextPlayerIndex = (++i) < players.Length ? i : 0;
                    break;
                }
            }

            return players[nextPlayerIndex];
        }
    }
}
