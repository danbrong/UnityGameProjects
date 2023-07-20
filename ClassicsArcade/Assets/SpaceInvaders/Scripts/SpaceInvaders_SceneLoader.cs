using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceInvaders_SceneLoader : MonoBehaviour
{
    public SceneLoader loader;

    public void LoadNextLevel()
    {
        loader.LoadNextLevel();
    }

    public void RestartGame()
    {
        loader.LoadNextLevel(-1);
    }

    public void MainMenu()
    {
        loader.LoadMainMenu();
    }
}
