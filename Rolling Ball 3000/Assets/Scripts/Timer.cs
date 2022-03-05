using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float time;
    int finishTime;
    int seconds;
    public Text timerUI;
    private bool timeStatus;

    void Start()
    {
        time = 0;
        timeStatus = true;
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
            timerUI.text = "Time: " + seconds;
        }

    }

    public void UpdateScore(bool time)
    {
        timeStatus = time;
    }
}
