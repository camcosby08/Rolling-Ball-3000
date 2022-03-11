using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionManager : MonoBehaviour
{
    public bool timeOn;
    private GameManagerScript gameManagerScript;

    [SerializeField] string deathTag;
    [SerializeField] string finishLevelTag;

    void Awake()
    {
        gameManagerScript = GameObject.FindObjectOfType<GameManagerScript>();
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
        if (collision.collider.tag == finishLevelTag && SceneManager.GetActiveScene().name != "Level3")
        {
            gameManagerScript.completeLevel();
        }
        if (collision.collider.tag == finishLevelTag && SceneManager.GetActiveScene().name == "Level3")
        {
            timeOn = false;
            gameManagerScript.UpdateScore(timeOn);
            gameManagerScript.completeGame();
        }
    }
}
