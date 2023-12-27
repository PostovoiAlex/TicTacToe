using System;
using UnityEngine;

namespace TicTacToe
{
    public class Field : MonoBehaviour
    {
        [SerializeField] GameObject _tilePrefab;
        [SerializeField] int _dimentions;

        Tile _lastSelectedTile;
        public Tile LastSelectedTile => _lastSelectedTile;
        
        public Action OnTileSelected;
        
        [ContextMenu("Init")]
        public void Init()
        {
            for (int i = 0; i < _dimentions; i++)
            {
                for (int j = 0; j < _dimentions; j++)
                {
                    Tile copy = Instantiate(_tilePrefab, transform).GetComponent<Tile>();
                    copy.Init();
                    copy.OnTileClicked += OnTileClicked;
                    copy.transform.localPosition = new Vector3(200 * i, 200 * j, 0);
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
    }
}
