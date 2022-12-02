using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;
    
    Player player;

    public Text TotalScore;
    public Text scoreText;

    public EndMenu endmenu;
    public RestartMenu restartMenu;

    public void Start()
    {
        CurrentScore = 0;
        
    }

    public void Update()
    {
        scoreText.text = "Score : " + CurrentScore.ToString();
        TotalScore.text = "Total Score : " + CurrentScore.ToString();
    }


    public void Die()
    {
        if (player.isDead == true)
        {
            
            endmenu.gameObject.SetActive(true);
            restartMenu.gameObject.SetActive(true);
        }
        
    }
    

}
