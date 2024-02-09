using System;
using System.Collections.Generic;
using UnityEngine;

namespace TicTacToe
{
    public class Player : MonoBehaviour
    {
        [SerializeField] TileStyle _tileStyle;

        private Field _filed;
        private List<Tile> _ownedTiles;

        public Action OnPlayerTurnStarted;
        public Action OnPlayerTurnEnded;

        public void Init(Field field)
        {
            _filed = field;
            _ownedTiles = new List<Tile>();
        }
        public void StartTurn()
        {
            _filed.OnTileSelected += OnTileSelected;
            OnPlayerTurnStarted?.Invoke();
        }

        public void EndTurn()
        {
            _filed.OnTileSelected -= OnTileSelected;
            OnPlayerTurnEnded?.Invoke();
        }

        private void OnTileSelected(Tile tile)
        {
            _ownedTiles.Add(tile);
            tile.SetStyle(_tileStyle);
            tile.SetOwner(this);
        }
    }
}