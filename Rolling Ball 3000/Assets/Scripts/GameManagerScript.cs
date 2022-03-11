using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    float time;
    public static int seconds;
    public static int finishTime;
    public Text timerUI;
    public Text scoreUI;
    private static bool timeStatus = true;

    public GameObject completeLevelUI;

    void Start()
    {
        time = seconds;
        //timeStatus = true;
        //scoreUI.text = "Hey";
    }

    void Update()
    {
        if (timeStatus)
        {        
            time += Time.deltaTime;
            seconds = (int)time % 60;
            timerUI.text = "Time: " + seconds; 
        }
        else
        {
            this.enabled = false;
            finishTime = seconds;
            scoreUI.text = "Score: " + finishTime;
            this.enabled = true;
            //timeStatus = true;
        }
    }

    public void UpdateScore(bool time)
    {
        timeStatus = time;
    }

    public void completeLevel()
    {
        Debug.Log("FINSHED LEVEL BITCHHHHHHHHHH");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void completeGame()
    {
        Debug.Log("COMPLETED THE GAME BITCHHHHHHHHHH");
        Debug.Log(seconds);
        completeLevelUI.SetActive(true);

        //scoreUI.text = "Score: HJFLDKJKSDLHFKLJDS ";
    }

    public void setTime()
    {
        //time = 0f;
    }
}
