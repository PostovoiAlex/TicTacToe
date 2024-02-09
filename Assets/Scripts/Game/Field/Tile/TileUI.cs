using System;
using System.Collections;
using System.Collections.Generic;
using TicTacToe;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TileUI : MonoBehaviour
{
    [SerializeField] Button _button;
    [SerializeField] TMP_Text _text;
    [SerializeField] Image _image;
    public Image Image => _image;
    public Action OnTileUIClicked { get; set; }

    public void Init()
    {
        _button.onClick.AddListener(OnClicked);
    }

    public void SetSprite(Sprite sprite)
    {
        _image.sprite = sprite;
    }

    private void OnClicked()
    {
        OnTileUIClicked?.Invoke();
    }
}
