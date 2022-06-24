using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Created By M. Fauzi Zain - 149251970101-17");
        SceneManager.LoadScene("Gameplay");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
