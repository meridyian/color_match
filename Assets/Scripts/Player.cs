using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 10f;


    public Rigidbody2D rb;
    public SpriteRenderer sr;


    public string currentColor;

    public Color colorCyan;
    public Color colorYellow;
    public Color colorPink;
    public Color colorMagenta;


    private void Start()
    {
        SetRandomColor();

    }

    // update is called per frame

    void Update()
    {

        // check if a jump or left mouse click 
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            // not force since we dont want it to compete with velocity while falling
            rb.velocity = Vector2.up * jumpForce;
        }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag != currentColor)
        {
            Debug.Log("GAME OVER!!!");
        }
    }


    void SetRandomColor()
    {
        int index = Random.Range(0,4);

        switch (index)
        {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Pink";
                sr.color = colorPink;
                break;
            case 3:
                currentColor = "Magenta";
                sr.color = colorMagenta;
                break;

        }

    }

}
