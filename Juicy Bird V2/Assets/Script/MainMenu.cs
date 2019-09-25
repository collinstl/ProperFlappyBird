using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject EscMenu;
    public GameObject SetMenu;

    private void Update()
    {

        //For activating in game menus
        if (Input.GetKeyDown(KeyCode.Escape) && EscMenu.activeInHierarchy)
        {
            EndEscMenu();
        }

        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            StartEscMenu();
        }
    }

    //Play button ()
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    //Quits the game. Wont work in unity editor.
    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    //Toggles Fullscreen
    public void ToggleFullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    //Activates and deactivates the pause or escape menu in game
    public void StartEscMenu()
    {
        Time.timeScale = 0f;
        EscMenu.SetActive(true);

    }

    public void EndEscMenu()
    {
        EscMenu.SetActive(false);
        SetMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}