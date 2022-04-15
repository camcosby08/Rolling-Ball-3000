using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    float time;
    public static int seconds;
    public static int min;
    //public static int finishTime = 0;
    public Text timerUI;
    public Text scoreUI;
    public Text hsUI;
    public int highScoreMin;
    public int highScoreSec;
    private static bool timeStatus = true;

    public GameObject completeLevelUI;

    void Start()
    {
        time = (min * 60) + seconds;
        //get highscore 
        hsUI.text = "Best Time: " + PlayerPrefs.GetInt("hsm", 0).ToString() + " : " + PlayerPrefs.GetInt("hss", 0).ToString();
        Debug.Log("Current time status" + timeStatus);
    }

    void Update()
    {
        //calculate and display time to UI if the game hasnt been complete
        if (timeStatus)
        {
            time += Time.deltaTime;
            min = (int)time / 60;
            seconds = (int)time % 60;
            timerUI.text = "Time: " + min + " : " + seconds;
        }
        //if the game is complete stop updating the timer ie stop calling this method
        else
        {
            //this.enabled = false; //stop using the update function as is it updates every frame
            string finishTime = min + " : " + seconds;
            scoreUI.text = "Final Time: " + finishTime;

            //adding Player prefs programming
            //int highScore = seconds;
            //Debug.Log(timeStatus);
            //Debug.Log(highScore);

            if (seconds < PlayerPrefs.GetInt("hss", 61))
            {
                Debug.Log("ran if statement");
                PlayerPrefs.SetInt("hss", seconds);
                this.enabled = (false);
            
            }
            if (min < PlayerPrefs.GetInt("hsm", 100))
            {
                PlayerPrefs.SetInt("hsm", min);
                this.enabled = (false);
     
            }
        }
    }

    //method to take the boolean from the collision manager script and flip our local timeStatus 
    //so we know the game is done 
    public void UpdateScore(bool completeBool)
    {
        timeStatus = completeBool;
    }

    //method to run when when a level is complete
    public void completeLevel()
    {
        Debug.Log("FINSHED LEVEL");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //method to run if the game is complete
    public void completeGame()
    {
        //add PlayerPrefs programming 
        
        Debug.Log("COMPLETED THE GAME");
        Debug.Log(seconds);
        completeLevelUI.SetActive(true);
    }

    public void setTime(float resetTime)
    {
        time = resetTime;
    }
}
