using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{

    private void Start()
    {
        Button StartGame_btn = transform.Find("StartGame_btn").GetComponent<Button>();
        Button ExitGame_btn = transform.Find("ExitGame_btn").GetComponent<Button>();


        StartGame_btn.onClick.AddListener(StartGame);
        ExitGame_btn.onClick.AddListener(ExitGame);

    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame() 
    {
        Application.Quit();
        Debug.Log("Game EXIT");
    }
}
