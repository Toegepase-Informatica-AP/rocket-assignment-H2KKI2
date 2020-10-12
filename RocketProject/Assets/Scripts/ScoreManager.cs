using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    public void IncreaseScore()
    {
        score++;
        SetScore();
    }

    private void SetScore()
    {
        if (scoreText)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
