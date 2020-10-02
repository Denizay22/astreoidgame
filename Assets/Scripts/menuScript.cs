using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuScript : MonoBehaviour
{
    public void QuitGame(){
        Application.Quit();
    }

    public void EnterCredits(){
        SceneManager.LoadScene("Credits");
    }

    public void EnterMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Gameplaying");
    }
}
