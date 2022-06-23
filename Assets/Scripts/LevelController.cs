using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController
{
    public static int CurrentLevelIndex = -1;
    public static void LoadLevel(int index)
    {
        Debug.Log(index + "th Level is Loading...");
        CurrentLevelIndex = index;
        SceneManager.LoadScene(index);
    }

    public static void LoadLevel(string levelName)
    {
        int index = SceneManager.GetSceneByName(levelName).buildIndex;
        LoadLevel(index);
    }

    public static void LoadNextLevel()
    {
        if (CurrentLevelIndex < 0)
            CurrentLevelIndex = SceneManager.GetActiveScene().buildIndex;
        LoadLevel(CurrentLevelIndex + 1);
    }

    public static void RestartLevel()
    {
        if (CurrentLevelIndex < 0)
            CurrentLevelIndex = SceneManager.GetActiveScene().buildIndex;
        LoadLevel(CurrentLevelIndex);
    }
}
