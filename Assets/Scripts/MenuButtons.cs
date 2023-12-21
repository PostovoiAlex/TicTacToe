using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private SceneAsset gameScene;
    [SerializeField] private SceneAsset menuScene;
    [SerializeField] private Button startGameButton;
    [SerializeField] private Button exitGameButton;
    [SerializeField] private Button mainMenuButton;

    private void Start()
    {
        startGameButton.onClick.AddListener(StartGame);
        exitGameButton.onClick.AddListener(ExitGame);
        mainMenuButton.onClick.AddListener(OpenMenu);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(gameScene.name);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game EXIT");
    }

    public void OpenMenu() 
    {
        SceneManager.LoadScene(menuScene.name);
    }
}
