using System;
using UnityEngine;

namespace TicTacToe
{
    public class Tile
    {
        [SerializeField] TileState _state;
        public TileState State => _state;

        [SerializeField] Player _playerOwner;
        public Player Owner => _playerOwner;

        [SerializeField] Tile[] _neighbours;
        [SerializeField] TileUI _tileUI;

        public Action<Tile> OnTileClicked;

        public void Init(TileUI tileUI)
        {
            _tileUI = tileUI;
            _tileUI.OnTileUIClicked += OnClicked;
            _tileUI.Init();

            _neighbours = new Tile[Enum.GetValues(typeof(Direction)).Length];
        }
        
        public void SetState(TileState state)
        {
            _state = state;
        }

        private void OnClicked()
        {
            OnTileClicked?.Invoke(this);
        }

        public void SetNeighbour(Direction direction, Tile tile, bool bidirectional = true)
        {
            _neighbours[(int)direction] = tile;
            if (bidirectional)
            {
                _neighbours[(int)direction].SetNeighbour(direction.Opposite(), this, false);
            }
        }

        public Tile GetNeighbour(Direction direction)
        {
            return _neighbours[(int)direction];
        }

        public void SetStyle(TileStyle style)
        {
            _tileUI.SetSprite(style.Sprite);
        }

        public void SetOwner(Player owner)
        {
            _playerOwner = owner;
        }
    }
}
