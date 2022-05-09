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

    private void Start()
    {
        gameOverText.SetActive(false);
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
    }
    public void increaseScore() {
        score++;
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
