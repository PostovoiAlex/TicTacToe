using UnityEngine;
using System;
using System.Collections;

namespace TicTacToe
{
    public class Turn : MonoBehaviour
    {
        Field _field;
        IEnumerator _currentTurn;

        bool _isWaiting;
        
        public Action OnTurnStarted;
        public Action OnTurnEnded;

        public void Init(Field field)
        {
            _field = field;
            _field.OnTileSelected += OnTileSelected;
        }
        
        void OnTileSelected(Tile tile)
        {
            _isWaiting = false;
        }

        public void StartTurn()
        {
            Debug.Log("Turn Started");
            
            _currentTurn = TurnCoroutine();
            StartCoroutine(_currentTurn);
            
            OnTurnStarted?.Invoke();
        }
        
        public void EndTurn()
        {
            StopCoroutine(_currentTurn);
            _currentTurn = null;
            
            OnTurnEnded?.Invoke();
            
            Debug.Log("Turn Ended");
        }

        private IEnumerator TurnCoroutine()
        {
            _isWaiting = true;

            yield return new WaitWhile(() => _isWaiting);
            
            EndTurn();
        }
    }
}
