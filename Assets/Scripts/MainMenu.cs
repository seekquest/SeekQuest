using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Main Menu MainMenu.cs
 * PlayGame(), Return(), QuitGame().
 * Cayas , Mendez 29/01/2024.
 */
public class MainMenu : MonoBehaviour
{
    public void PlayGame()//Initiates the Game via the play button on the canvasUI.
    {
        SceneManager.LoadScene(1);//loads the LEVEL1 Scene from Build Settings.
    }
    
    

    public void Return()
    {
        SceneManager.LoadScene(0);//Loads main menu from Build Settings
    }

    public void QuitGame()
    {
        Application.Quit();// Exits the Game / Very similar to ENvironment Exit.

    }
    
}


