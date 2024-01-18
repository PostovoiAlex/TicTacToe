using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class lvlButton : MonoBehaviour
{
    [SerializeField] lvlLoader _lvlLoader;
    [SerializeField] Button lvl_button;
    [SerializeField] TMP_Text lvl_Text;
    [SerializeField] int _lvlIndex;

    void Awake()
    {
        if (lvl_button)
        {
            lvl_button.onClick.AddListener(ButtonPressed);
        }
    }

    public void Init(lvlLoader lvlLoader, int lvlIndex)
    {
        _lvlLoader = lvlLoader;
        _lvlIndex = lvlIndex;

        InitUI();
    }
    
    void InitUI()
    {
        lvl_Text.text = _lvlIndex.ToString();
    }

    void ButtonPressed()
    {
        _lvlLoader.Switch_LVL(_lvlIndex);
    }
}
