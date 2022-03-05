using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionManager : MonoBehaviour
{
    public bool timeOn;
    private Timer timer;

    [SerializeField] string deathTag;
    [SerializeField] string finishLevelTag;

    void Awake()
    {
        timer = GameObject.FindObjectOfType<Timer>();
    }

    void Start()
    {
        timeOn = true;
        Debug.Log(timeOn);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == deathTag)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.collider.tag == finishLevelTag)
        {
            Debug.Log("Finshed the Level");
            timeOn = false;
            timer.UpdateScore(timeOn);
        }
    }
}
