using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 10f;


    public Rigidbody2D rb;

    // update is called per frame

    private void Update()
    {

        // check if a jump or left mouse click 
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            // not force since we dont want it to compete with velocity while falling
            rb.velocity = Vector2.up * jumpForce;
        }


    }
}
