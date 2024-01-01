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

    //load the scene called cars
    public void LoadCarsScene()
    {
        SceneManager.LoadScene("ShipSteering");
    }

    public void LoadShooterGame()
    {
        SceneManager.LoadScene("ShooterGame");
    }

    public void ARScene()
    {
        SceneManager.LoadScene("ARScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
