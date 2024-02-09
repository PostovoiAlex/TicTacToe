using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FieldUI : MonoBehaviour
{
    [SerializeField] private GameObject _tileUIPrefab;
    [SerializeField] private RectOffset _padding;
    [SerializeField] private Vector2 _spacing = Vector2.zero;
    [SerializeField] private Vector2 _tileSize = Vector2.zero;

   // [SerializeField] private Vector2 _fieldSize = Vector2.zero;

    [SerializeField] private GridLayoutGroup _gridLayoutGroup;


    public void Init(int fieldDimentions)
    {
        // _fieldSize = _spacing + (_spacing * fieldDimentions) + (_tileSize * fieldDimentions);

        _gridLayoutGroup.padding = _padding;
        _gridLayoutGroup.cellSize = _tileSize;
        _gridLayoutGroup.spacing = _spacing;
        _gridLayoutGroup.constraint = GridLayoutGroup.Constraint.FixedRowCount;
        _gridLayoutGroup.constraintCount = fieldDimentions;
    }
    public TileUI CreateTileUI()
    {
        TileUI tileUI = Instantiate(_tileUIPrefab, transform).GetComponent<TileUI>();

        if(tileUI == null) 
        {
            Debug.Log("TileUI component not found");
            return null;
        }

        //tileUI.transform.localPosition = GetTileUIPos(x, y);

        return tileUI;
    }

    //private Vector2 GetTileUIPos(int x, int y)
    //{
    //    Vector2 result;
    //    result.x = _spacing.x + (_spacing.x * x) + _tileSize.x / 2 + (_tileSize.x * x) - _fieldSize.x / 2;
    //    result.y = _spacing.y + (_spacing.y * y) + _tileSize.y / 2 + (_tileSize.y * y) - _fieldSize.y / 2;
    //    return result;
    //}
}
