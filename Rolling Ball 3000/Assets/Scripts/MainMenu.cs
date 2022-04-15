using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour   
{
    private GameManagerScript gameManagerScript;

    void Awake()
    {
        gameManagerScript = GameObject.FindObjectOfType<GameManagerScript>();
        //gameManagerScript.UpdateScore(true);
        //gameManagerScript.setTime(0f);
    }

    public void playGame()
    {
        SceneManager.LoadScene("Level1");
        //gameManagerScript.UpdateScore(true);
    }

    public void quitGame()
    {
        Application.Quit();
        //PlayerPrefs.DeleteAll();
        Debug.Log("Quitting Game");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        gameManagerScript.UpdateScore(true);
        gameManagerScript.setTime(0f);
    }
}
