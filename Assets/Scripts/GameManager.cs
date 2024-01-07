using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Player[] player;
    [SerializeField] Ui_DisplayPlayerName uiName;

    public void Awake()
    {
        for (int i = 0; i < player.Length; i++) 
        {
            player[i].OnPlayerTurnEnded += OnPlayerTurnEnded;
        }

    }

    public void OnPlayerTurnEnded()
    { 
        int rand = Random.Range(0, player.Length);
        player[rand].StartTurn();
        uiName.DisplayName(player[rand].PlayerName);
    }

    public void Start()
    {
        OnPlayerTurnEnded();    
    }
}
