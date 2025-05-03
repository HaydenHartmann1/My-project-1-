using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }
    public void playGame2()
    {
        SceneManager.LoadScene(3);
    }
    public void playGame3()
    {
        SceneManager.LoadScene(5);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MapSelection()
    {
        SceneManager.LoadScene(4);
        // This method will be attached to the MapSelection button
        // Will bring you to map selection scene and then can pick from maps

        // 2. Get background for main menus?
        // 3. Get terrain background?
        // 4. Get textures for objects?
    }

    public void MainMenuScreen()
    {
        SceneManager.LoadScene(0);
    }
}
