using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public void increaseScore() {
        score++;
        scoreText.text = "Coins: " + score.ToString();
    }
}
