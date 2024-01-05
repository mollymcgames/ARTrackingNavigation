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
    
    public void LoadBook()
    {
        SceneManager.LoadScene("Book");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadChapter1()
    {
        SceneManager.LoadScene("Chapter1");
    }

    public void LoadChapter2()
    {
        SceneManager.LoadScene("Chapter2");
    }

    public void LoadChapter3()
    {
        SceneManager.LoadScene("Chapter3");
    }

    public void LoadChapter4()
    {
        SceneManager.LoadScene("Chapter4");
    }

    public void LoadChapter5()
    {
        SceneManager.LoadScene("Chapter5");
    }

    public void LoadChapter6()
    {
        SceneManager.LoadScene("Chapter6");
    }

    public void LoadChapter7()
    {
        SceneManager.LoadScene("Chapter7");
    }

    public void LoadChapter8()
    {
        SceneManager.LoadScene("Chapter8");
    }
}
