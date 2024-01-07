using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ui_DisplayPlayerName : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text _text;

    public void DisplayName(string name)
    {
        _text.text = $"Current turn is: {name}";
    }
}
