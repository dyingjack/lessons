﻿using UnityEngine;


public class player_movement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upwardsForce = 300F;

    
  
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d") )
        {

            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {

            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }



        if (Input.GetKey("w"))
        {

            rb.AddForce(0, upwardsForce * Time.deltaTime, 0, ForceMode.VelocityChange);

        }

        if (rb.position.y < -1f)
        {

            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
