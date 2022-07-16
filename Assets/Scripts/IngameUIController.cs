using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IngameUIController : MonoBehaviour
{
    public GameObject[] hearts;
    public GameObject key;
    public TextMeshProUGUI levelText;

    private void Start()
    {
        levelText.text = "Level " + LevelController.CurrentLevelIndex;
    }

    public void UpdateKey(bool hasKey)
    {
        if (hasKey)
        {
            key.SetActive(true);
        }
        else
        {
            key.SetActive(false);
        }
    }

    /*
     *  0: [][][]
     *  1: [x][][]
     *  2: [x][x][]
     *  3: [x][x][x]
     */
    public void UpdateHealth(int hp) 
    {
        if (hp > 2)
        {
            hearts[2].SetActive(true); //First index is hearts[0]
        }
        else
        {
            hearts[2].SetActive(false);
        }

        if (hp > 1)
        {
            hearts[1].SetActive(true);
        }
        else
        {
            hearts[1].SetActive(false);
        }

        if (hp > 0)
        {
            hearts[0].SetActive(true);
        }
        else
        {
            hearts[0].SetActive(false);
        }
    }
}
