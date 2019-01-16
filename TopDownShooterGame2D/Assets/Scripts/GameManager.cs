using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //Setting bool used for pausing the game.
    public static bool IsGamePaused = false;
    public GameObject PauseMenuUI;

    //Starts the Aracde Game Mode.
    public void StartArcadeGame()
    {
        SceneManager.LoadScene("ArcadeMode");
    }

    //Starts the Story Game Mode.
    public void StartStoryGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StoryMode");
    }

    //Ends the Game.
    public void EndGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("EndScreen");
    }

    //Moves onto the main menu Scene.
    public void BackToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    //Checks for users to preee Pause Game Button.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    //Used for Unpauing Time and Turning off the pause screen.
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsGamePaused = false;
    }

    //Used for pausing the game and turning on the Pause Screen.
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        IsGamePaused = true;
        
    }

    //Used to Exit the game and Close it.
    public void QuitGame()
    {
        Application.Quit();
    }

}
