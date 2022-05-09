using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameOverText;
    public int startTime = 120;
    public Text countdownText;
    public GameObject playerController;
    public GameObject winText;
    public int coinsRequired = 100;

    private void Start()
    {
        gameOverText.SetActive(false);
        winText.SetActive(false);
        InvokeRepeating("countDown", 1f, 1f);
    }

    public void Update()
    {
        if (startTime <= 0) {
            gameOver();
            CancelInvoke("countDown");
            startTime = 0;
            countdownText.text = "Time: " + startTime.ToString();
        }
        if (score >= coinsRequired)
        { 
            CancelInvoke("countDown");
            playerController.SetActive(false);
            winText.SetActive(true);
        }
    }
    public void increaseScore() {
        score++;
        scoreText.text = "Coins: " + score.ToString();
    }

    public void increaseScoreMore()
    {
        score+= 5;
        scoreText.text = "Coins: " + score.ToString();
    }

    public void increaseScoreMega()
    {
        score += 10;
        scoreText.text = "Coins: " + score.ToString();
    }

    public void gameOver() {
        gameOverText.SetActive(true);
        playerController.SetActive(false);
    }

    public void countDown() {
        startTime--;
        countdownText.text = "Time: " + startTime.ToString();
    }
}
