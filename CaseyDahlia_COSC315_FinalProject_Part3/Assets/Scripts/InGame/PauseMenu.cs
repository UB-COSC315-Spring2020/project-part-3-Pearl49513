using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //Status that game is Paused
    public static bool GamePaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
       //Player press the P key on the keyboard to pause the game
       if (Input.GetKeyDown(KeyCode.P))
       {
            Pause();
       }
    }

    //Selected when players want to go back into the game
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    //Uses when Paused Menu shows up and the game is static
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void SaveGame()
    {
        Debug.Log("Load System active");
    }

    //Player selected Yes to go back to Main Menu without saving
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    //Player select Yes when quitting the game without saving
    public void QuitGame()
    {

        Debug.Log("Quit Game");
        Application.Quit();
    }

}
