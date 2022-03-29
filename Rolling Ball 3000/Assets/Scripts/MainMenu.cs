using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour   
{
    private GameManagerScript gameManagerScript;

    //void Awake()
    //{
    //    gameManagerScript = GameObject.FindObjectOfType<GameManagerScript>();
    //}

    public void playGame()
    {
        SceneManager.LoadScene("Level1");
        //gameManagerScript.setTime();
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Quitting Game");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
