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

    //Awake is called either when an active GameObject that contains the script is 
    //initialized when a Scene loads, or when a previously inactive GameObject is set to active, 
    //or after a GameObject created with Object. Instantiate is initialized. Use Awake to initialize 
    //variables or states before the application starts.
    //Unity documentation on how awake works
    void Awake()
    {
        //find the game manager script so we can use its methods
        gameManagerScript = GameObject.FindObjectOfType<GameManagerScript>();
    }

    void Start()
    {
        timeOn = true;
        //Debug.Log(timeOn);
    }

    void OnCollisionEnter(Collision collision)
    {
        //check if player fell off the level 
        if (collision.collider.tag == deathTag)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        //check if player finished a level
        if (collision.collider.tag == finishLevelTag && SceneManager.GetActiveScene().name != "Level3")
        {
            gameManagerScript.completeLevel();
        }
        //check if player finished the game
        if (collision.collider.tag == finishLevelTag && SceneManager.GetActiveScene().name == "Level3")
        {
            timeOn = false;
            gameManagerScript.UpdateScore(timeOn); //use to pass boolean to the game manager script
            gameManagerScript.completeGame(); //use to run the complete game method 
        }
    }
}
