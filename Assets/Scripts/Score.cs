using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static float CurrentScore = 0f;
    Player player;

    public Text scoreText;
    public Text totalScoreText;

    public void TotalScore()
    {
        scoreText.text = CurrentScore.ToString(); 
    }


    public void Die()
    {
        player.isDead = true;

    }
    

}
