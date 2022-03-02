using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] KeyCode restartButton;

    //Apply a constant force 
    void FixedUpdate()
    {
        //restart level programming
        if (Input.GetKey(restartButton))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
