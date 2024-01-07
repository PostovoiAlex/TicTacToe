using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Turn turn;
    [SerializeField] string playerName;
    public string PlayerName { get { return playerName; } }
    public string GetPlayerName() 
    { 
        return playerName;
    }


    public void Awake()
    {
        turn.OnTurnEnded += OnTurnEnded;

    }

    public void OnTurnEnded() 
    {
        Debug.Log("Player turn end" + gameObject.name);
        OnPlayerTurnEnded?.Invoke();
    }

    [ContextMenu("Start turn")]
    public void StartTurn() 
    {
        turn.StartTurn();
    }

    public Action OnPlayerTurnEnded;
}


