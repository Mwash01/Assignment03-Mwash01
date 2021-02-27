using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    void Start() {
        scoreText.text = "Score: " + Data.scoreNum.ToString();
    }
}
