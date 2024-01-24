using System;
using UnityEngine;

namespace TicTacToe
{
    public class Field : MonoBehaviour
    {
        [SerializeField] GameObject _tilePrefab;
        [SerializeField] int _dimentions;

        Tile[,] _grid;

        Tile _lastSelectedTile;
        public Tile LastSelectedTile => _lastSelectedTile;

        public Action OnTileSelected;

        [ContextMenu("Init")]
        public void Init()
        {
            _grid = new Tile[_dimentions, _dimentions];
            for (int i = 0; i < _dimentions; i++)
            {
                for (int j = 0; j < _dimentions; j++)
                {
                    Tile copy = Instantiate(_tilePrefab, transform).GetComponent<Tile>();
                    copy.Init();
                    copy.OnTileClicked += OnTileClicked;
                    copy.transform.localPosition = new Vector3(200 * i, 200 * j, 0);

                    _grid[i, j] = copy;
                }
            }
        }

        public void SetTileSprite(Tile tile, Sprite sprite)
        {
            tile.SetSprite(sprite);
        }

        private void OnTileClicked(Tile tile)
        {
            if (tile.State != TileState.Empty)
            {
                return;
            }

            _lastSelectedTile = tile;
            _lastSelectedTile.SetState(TileState.Filled);
            OnTileSelected?.Invoke();
        }

        public bool CheckTileWinCombination(Tile tile)
        {
            // [ 0 0 0 ]
            // [ 0 X 0 ]
            // [ 0 0 0 ]

            // [ 0 0 0 0 ]
            // [ 0 0 X 0 ]
            // [ 0 0 0 0 ]

            for (int i = 0; i < _dimentions; i++)
            {
                for (int j = 0; j < _dimentions; j++)
                {
                    // 0 0 && 1 0 && 2 0
                    // 0 1 && 1 1 && 2 1
                }
            }


            // 0 0 && 1 0 && 2 0


            //bool isWin = false;
            //if (tile.X_Pos + 1 < _dimentions && tile.X_Pos - 1 > 0)
            //{
            //    if(_grid[tile.X_Pos, tile.Y_Pos].Image.sprite == _grid[tile.X_Pos + 1, tile.Y_Pos].Image.sprite &&
            //       _grid[tile.X_Pos, tile.Y_Pos].Image.sprite == _grid[tile.X_Pos - 1, tile.Y_Pos].Image.sprite)
            //    {
            //        isWin = true;
            //    }
            //}

            //if(isWin)
            //{
            //    Debug.Log("WIN");
            //}
           

            return false;
        }
    }
}
