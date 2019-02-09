﻿//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    //public GameManager gameManager;

    //is called whenever player collides with something, player should have rigidbody and collider added to it 
    void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);

        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an Obstacle!");
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
