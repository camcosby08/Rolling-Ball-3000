using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour

{
    private GameManagerScript gameManagerScript;

    [SerializeField] Vector3 v3Force;

    [SerializeField] KeyCode positive;
    [SerializeField] KeyCode negative;

    [SerializeField] KeyCode restartButton;
    [SerializeField] KeyCode quitButton;
    [SerializeField] KeyCode mainMenuButton;

    void Awake()
    {
        gameManagerScript = GameObject.FindObjectOfType<GameManagerScript>();
    }

    //Apply a constant force 
    void FixedUpdate()
    {
        if (Input.GetKey(positive))
        {
            GetComponent<Rigidbody>().velocity += v3Force;
        }
        if (Input.GetKey(negative))
        {
            GetComponent<Rigidbody>().velocity -= v3Force;
        }
        if (Input.GetKey(restartButton))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKey(quitButton))
        {
            Application.Quit();
            Debug.Log("Quitting Application");
        }
        if (Input.GetKey(mainMenuButton))
        {
            gameManagerScript.setTime(0f);
            SceneManager.LoadScene("MainMenu");
        }
    }
}
