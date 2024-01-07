using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwithSceneButton : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] SceneAsset sceneAsset;

    public void SwithScene() 
    {
        SceneManager.LoadScene(sceneAsset.name);
    }
    // Start is called before the first frame update
    void Start()
    {
        if (button != null)
        {
            button.onClick.AddListener(SwithScene);
        }
    }
}
