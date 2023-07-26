using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("Home Screen");
    }
}