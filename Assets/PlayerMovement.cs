//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //reference to Rigidbody component
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, world");
        //sets gravity
        //rb.useGravity = false;
        //sets forces in x, y, z direction respectively
        rb.AddForce(0, 200, 500);
    }


    // marked FixedUpdate because we are for physics
    // Update is called once per frame
    void FixedUpdate()
    {
        //Add force of 2000 on y axis
        rb.AddForce(0, 0, 200 * Time.deltaTime);
    }
}
