using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private float score = 100f;
    private float scorecoef = 0f;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ColorChanger"))
        {
            scorecoef += 1;
            score = score * scorecoef;
            Debug.Log(score);
        }

    }

}
