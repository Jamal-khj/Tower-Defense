using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using Jamal.Script;)

public class StartGame : MonoBehaviour
{
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("Level Selection");
        Time.timeScale = 1.0f;
    }
}