using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 100f;

    // Update is called once per frame
    void Update()
    {
        //rotate around speed
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }


    // register whenever we collide with something

    void OnTriggerEnter2D(Collider2D col)
    {
        // check the tags and colors


        Debug.Log(col.tag);

    }
}
