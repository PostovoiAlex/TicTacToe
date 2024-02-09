using System;
using UnityEngine;

namespace TicTacToe
{
    public class Field : MonoBehaviour
    {
        [SerializeField] FieldUI _fieldUI;
        [SerializeField] int _dimentions;

        Tile[,] _grid;

        Tile _lastSelectedTile;
        public Tile LastSelectedTile => _lastSelectedTile;

        public Action<Tile> OnTileSelected;

        [ContextMenu("Init")]
        public void Init()
        {
            _fieldUI.Init(_dimentions);
            _grid = new Tile[_dimentions, _dimentions];
            for (int y = 0; y < _dimentions; y++)
            {
                for (int x = 0; x < _dimentions; x++)
                {
                    Tile tile = new Tile();
                    tile.Init(_fieldUI.CreateTileUI());
                    tile.OnTileClicked += OnTileClicked;

                    _grid[x, y] = tile;
                    SetNeighbours(x, y);
                }
            }
        }

        private void SetNeighbours(int x, int y)
        {
            if(x > 0)
            {
                _grid[x, y].SetNeighbour(Direction.Left, _grid[x - 1, y]);

                if(y > 0)
                {
                    _grid[x, y].SetNeighbour(Direction.UpLeft, _grid[x - 1, y - 1]);
                    
                    if (x < _dimentions - 1)
                    {
                        _grid[x, y].SetNeighbour(Direction.UpRight, _grid[x + 1, y - 1]);
                    }
                }
            }

            if (y > 0)
            {
                _grid[x, y].SetNeighbour(Direction.Up, _grid[x, y - 1]);
            }
        }

        private void OnTileClicked(Tile tile)
        {
            if (tile.State != TileState.Empty)
            {
                return;
            }

            _lastSelectedTile = tile;
            _lastSelectedTile.SetState(TileState.Filled);
            OnTileSelected?.Invoke(tile);
        }
    }
}
