using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame()
    {
        Debug.Log("Oyundan Cikildi");
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
