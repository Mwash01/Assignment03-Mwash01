using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsPrint : MonoBehaviour
{
    public Text score;
    public Text lives;
    void Start()
    {
        score.text = "Score: " + Data.scoreNum.ToString();
        lives.text = "Lives Remaining: " + Data.playerLives.ToString();
    
    }
}
