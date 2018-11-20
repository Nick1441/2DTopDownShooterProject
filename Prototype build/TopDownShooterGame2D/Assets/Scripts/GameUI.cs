using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

    public Slider healthBar;
    public Text ScoreText;
    private Animator DamgedBar;

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
        healthBar.GetComponent<Animator>().SetBool("ifDamage", true);
        Invoke("OffDamage", 0.5f);
    }

    private void OffDamage()
    {
        healthBar.GetComponent<Animator>().SetBool("ifDamage", false);
    }

    private void UpdateScore(int theScore)
    {
        playerScore += theScore;
        ScoreText.text = "SCORE : " + playerScore.ToString();
    }

    public void FixedUpdate()
    {
        PlayerPrefs.SetString("Player Score", ScoreText.text);
    }

    private void Start()
    {
        DamgedBar = healthBar.GetComponent<Animator>();
    }
}
