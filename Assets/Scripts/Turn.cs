using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Turn : MonoBehaviour
{

    [SerializeField] float turnDuration;
    [SerializeField] float currentTurnDuration;

    private bool isTurn;

    public event Action OnTurnEnded;

    public void Update()
    {
        if (isTurn) 
        {
            if (currentTurnDuration > 0)
            {
                currentTurnDuration = currentTurnDuration - Time.deltaTime;
                return;
            }

            isTurn = false;
            EndTurn();
            
        }
    
    }

    public void EndTurn() 
    {
        OnTurnEnded?.Invoke();
    }

    public void StartTurn()
    {
        currentTurnDuration = turnDuration;
        Debug.Log("Turn Started");
        isTurn = true;
        return;

    }
}
