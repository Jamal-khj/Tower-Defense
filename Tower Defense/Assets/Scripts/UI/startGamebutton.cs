using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class startGamebutton : MonoBehaviour
{
    public GameObject gameButton;
    public GameObject pauseMenu;

    private void Start()
    {
        gameButton.SetActive(true);
        Time.timeScale = 0.0f;
        pauseMenu.SetActive(false);
    }
    public void PlayButton()
    {
        gameButton.SetActive(false);
        Time.timeScale = 1.0f;
        pauseMenu.SetActive(true);
    }
}