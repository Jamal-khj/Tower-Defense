using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using Jamal.Script;)

public class MainMenuLoader : MonoBehaviour
{
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("Home Screen");
        Time.timeScale = 1.0f;
    }
}