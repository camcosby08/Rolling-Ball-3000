﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] Vector3 v3Force;

    [SerializeField] KeyCode positive;
    [SerializeField] KeyCode negative;

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
    }
}
