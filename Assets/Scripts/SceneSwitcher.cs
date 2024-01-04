using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    //Load the next scene in the build index
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1); //or do SceneManager.LoadScene("SceneName");
    }

    public void LoadPreviousScreen()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex - 1); //or do SceneManager.LoadScene("SceneName");
    }

    public void LoadShipScene()
    {
        SceneManager.LoadScene("ShipSteering");
    }   


    public void LoadMine()
    {
        SceneManager.LoadScene("Mine");
    }        

    public void LoadShooterGame()
    {
        SceneManager.LoadScene("ShooterGame");
    }

    public void ARScene()
    {
        SceneManager.LoadScene("ARScene");
    }

    public void LoadHome()
    {
        SceneManager.LoadScene("Home");
    }

    public void LoadSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
