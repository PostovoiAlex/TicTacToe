using System;
using TicTacToe;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(WinCondition), menuName = nameof(WinCondition))]
public class WinCondition : ScriptableObject
{
    [SerializeField] int combination;

    public bool CheckCondition(Tile tile)
    {
        Player tileOwner = tile.Owner;
        Tile neighbourTile;
        bool isCorrect = false;
        foreach (Direction direction in Enum.GetValues(typeof(Direction)))
        {
            isCorrect = true;
            neighbourTile = tile;
            for (int i = 1; i < combination; i++)
            {
                neighbourTile = neighbourTile.GetNeighbour(direction);
                if (neighbourTile == null || neighbourTile.Owner != tileOwner)
                {
                    isCorrect = false;
                    break;
                }
            }

            if (isCorrect)
            {
                break;
            }
        }

        return isCorrect;
    }
}