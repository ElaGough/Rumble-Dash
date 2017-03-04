using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//class used for buttons
public class Menu : MonoBehaviour {

    public string mainMenuScene;
    public string mainGameScene;
    public string backStoryScene;
    public string controlsScene;

    public void MenuScene()
    {
        SceneManager.LoadScene(mainMenuScene);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(mainGameScene);
    }

    public void Controls()
    {
        SceneManager.LoadScene(controlsScene);
    }

    public void BackStory()
    {
        SceneManager.LoadScene(backStoryScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
