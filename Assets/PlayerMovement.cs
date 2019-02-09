//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //reference to Rigidbody component
    public Rigidbody rb;

    public float forwardForce = 200f;
    public float slidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, world");
        //sets gravity
        //rb.useGravity = false;
        //sets forces in x, y, z direction respectively
        //rb.AddForce(0, 200, 500);
    }


    // marked FixedUpdate because we are for physics
    // Update is called once per frame
    void FixedUpdate()
    {
        //Add a forward force on y axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(slidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-slidewaysForce * Time.deltaTime, 0, 0);
        }

    }
}
