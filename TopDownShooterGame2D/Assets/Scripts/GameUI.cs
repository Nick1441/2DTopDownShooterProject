using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

    //Sets the UI's Componets to be used for the UI.
    public Slider healthBar;
    public Text ScoreText;
    private Animator DamgedBar;

    //Sets the players score the 0 every start of the game.
    public int playerScore = 0;

    //Sets the score and health bars.
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

    //Updates the health Bar, plays animation for damaging Healthbar.
    private void UpdateHealthBar(int health)
    {
        healthBar.value = health;
        healthBar.GetComponent<Animator>().SetBool("ifDamage", true);
        Invoke("OffDamage", 0.5f);
    }

    //Sets the damage animation to off after half a second.
    private void OffDamage()
    {
        healthBar.GetComponent<Animator>().SetBool("ifDamage", false);
    }

    //Updates score Text.
    private void UpdateScore(int theScore)
    {
        playerScore += theScore;
        ScoreText.text = "SCORE : " + playerScore.ToString();
    }

    //Continously updating the score and score text to use in End Game Scene.
    public void FixedUpdate()
    {
        PlayerPrefs.SetString("Player Score", ScoreText.text);
        PlayerPrefs.SetInt("Score", playerScore);
    }

    //Gets Health bar component on start of Game.
    private void Start()
    {
        DamgedBar = healthBar.GetComponent<Animator>();
    }
}