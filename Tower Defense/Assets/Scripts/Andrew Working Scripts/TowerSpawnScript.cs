using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawnScript : MonoBehaviour
{

    //attached to main camera

    public GameObject towerPrefab;

    private Vector3 mousePos;

    private bool canPlace;
    private bool releasedButton;

    LinkedList<GameObject> towers = new();

    void Start()
    {
        canPlace = false;
        releasedButton = true;

    }

    // Update is called once per frame
    void Update()
    {
        MouseInput();
        SpawnTower();
    }

    public void MouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            canPlace = true;
            releasedButton = false;
            mousePos = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            canPlace = false;
            releasedButton = true;
        }
    }

    public void SpawnTower()
    {
        if (releasedButton == false && canPlace == true)
        {
            GameObject spawnedTower = Instantiate(towerPrefab);

            spawnedTower.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 5));
            canPlace = false;
        }
    }
}
