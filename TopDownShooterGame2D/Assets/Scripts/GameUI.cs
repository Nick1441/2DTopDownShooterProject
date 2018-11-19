using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

    public Slider healthBar;
    public Text ScoreText;

    public int playerScore = 0;

    private void OnEnable()
    {
        Player.OnUpdateHealth += UpdateHealthBar;
        Score.OnSendScore += UpdateScore;
    }

    private void OnDisable()
    {
        Player.OnUpdateHealth -= UpdateHealthBar;
        Score.OnSendScore -= UpdateScore;
    }

    private void UpdateHealthBar(int health)
    {
        healthBar.value = health;
        healthBar.GetComponent<Animator>().Play(0);
    }

    private void UpdateScore(int theScore)
    {
        playerScore += theScore;
        ScoreText.text = "Score " + playerScore.ToString();
    }

    public void Start()
    {
        healthBar.GetComponent<Animator>().StopPlayback();
    }
}
