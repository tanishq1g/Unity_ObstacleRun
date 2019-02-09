//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //for the Transform type of objects
    public Transform player;

    //Vector3 stores 3 numbers
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position);

        //transform attached to the current object i.e. Camera
        transform.position = player.position + offset;
    }
}
