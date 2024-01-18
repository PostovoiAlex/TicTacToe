using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvlLoader : MonoBehaviour
{
    [SerializeField] List<SceneAsset> _scenes;
    [SerializeField] GameObject _sceneButtonPrefab;

    public void Awake()
    {
        Create_LVL_Buttons();
    }

    public void Create_LVL_Buttons()
    {
        for (int i = 0; i < _scenes.Count; i++)
        {
            GameObject newSceneButton = Instantiate(_sceneButtonPrefab, transform);

            lvlButton newLvlButton = newSceneButton.GetComponent<lvlButton>();
            //TODO: check if exist
            
            newLvlButton.Init(this, i);
        }
    }
    
    public void Switch_LVL(int lvlIndex)
    {
        SceneManager.LoadScene(_scenes[lvlIndex].name);
    }
}
