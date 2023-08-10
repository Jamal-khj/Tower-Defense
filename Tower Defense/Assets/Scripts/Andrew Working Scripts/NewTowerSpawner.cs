using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTowerSpawner : MonoBehaviour
{
    public GameObject semiAutoUI;

    void Awake()
    {
        semiAutoUI.SetActive(false);
    }

    public void OnMouseDown()
    {
        semiAutoUI.SetActive(true);
    }
}
