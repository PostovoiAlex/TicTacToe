using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    [SerializeField] Button _button;
    [SerializeField] TMPro.TMP_Text _text;
    [SerializeField] State _state;

    public void Awake()
    {
        _button.onClick.AddListener(OnClicked);

    }

    private void OnClicked()
    {
        SetState(State.Full);
    }

    public void SetState(State state)
    {
        _state = state;

        if (_state == State.Empty)
        {
            _text.text = "";
        }
        else
        {
            _text.text = "X";
        }
    }

    public State GetState()
    {
        return _state;
    }

    public enum State 
    { 
        Empty, Full
    }
}
