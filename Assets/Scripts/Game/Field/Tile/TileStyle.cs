using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(TileStyle), menuName = nameof(TileStyle))]
public class TileStyle : ScriptableObject
{
    [SerializeField] Sprite _sprite;
    public Sprite Sprite
    {
        get => _sprite;
        set => _sprite = value;
    }
}
