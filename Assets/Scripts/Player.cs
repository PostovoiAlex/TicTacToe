using System;
using UnityEngine;

namespace TicTacToe
{
    public class Player : MonoBehaviour
    {
        [SerializeField] Sprite _playerTileSprite;

        public Sprite PlayerTileSprite => _playerTileSprite;
        public Action OnPlayerTurnStarted;
        public Action OnPlayerTurnEnded;

        public void StartTurn()
        {
            OnPlayerTurnStarted?.Invoke();
        }

        public void EndTurn()
        {
            OnPlayerTurnEnded?.Invoke();
        }
    }
}