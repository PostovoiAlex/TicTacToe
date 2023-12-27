using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe
{
    public class Tile : MonoBehaviour
    {
        [SerializeField] Button _button;
        [SerializeField] TMP_Text _text;
        [SerializeField] Image _image;
        [SerializeField] TileState _state;
        
        public TileState State => _state;

        public Action<Tile> OnTileClicked;
        public void Init()
        {
            _button.onClick.AddListener(OnClicked);
        }

        public void SetSprite(Sprite sprite)
        {
            _image.sprite = sprite;
        }
        
        public void SetState(TileState state)
        {
            _state = state;
        }

        private void OnClicked()
        {
            OnTileClicked?.Invoke(this);
        }
    }
}
