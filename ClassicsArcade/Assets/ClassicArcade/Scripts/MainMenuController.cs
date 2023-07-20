using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public SceneLoader sceneLoader;

    public void MissileButton()
    {
        sceneLoader.LoadSceneName("MissileStartScreen");
    }
    public void TronButton()
    {
        sceneLoader.LoadSceneName("Tron_Welcome");
    }
    public void InvaderButton()
    {
        sceneLoader.LoadSceneName("SpaceInvaders_MenuScene");
    }

    /*
    //Example of how to link your button to your Game menu
    //sceneLoader.LoadSceneName is the preferred method for loading scenes

    public void GameButton()   //Name of your Button
    {
       sceneLoader.LoadSceneName("Game_Menu");  // Specify the name of your menu Scene
    }
    */
}
