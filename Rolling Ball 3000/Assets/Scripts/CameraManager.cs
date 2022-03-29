using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    void Start()
    {
        //calculate camera position
        offset = transform.position - player.transform.position;
    }

    //LateUpdate is called every frame, if the Behaviour is enabled. LateUpdate is called after all 
    //Update functions have been called. This is useful to order script execution. 
    //For example a follow camera should always be implemented in LateUpdate because it tracks objects 
    //that might have moved inside Update.
    //from unity documentation - HOW LATE UPDATE WORKS
    void LateUpdate()
    {
        //place the camera at the player position + the offset at all times
        transform.position = player.transform.position + offset;
    }
}
