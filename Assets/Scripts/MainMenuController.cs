using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void OnPlayButton()
    {
        LevelController.LoadLevel(1);
    }

    public void OnQuitButton()
    {
        Debug.Log("You are now exit from the game!");
        Application.Quit();
    }
}
