using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class TowerSpawnScript : MonoBehaviour
{

    //attached to main camera

    public GameObject towerPrefab;

    private Vector3 mousePos;

    private bool canPlace;
    private bool releasedButton;

    public int coinCount;

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

            /// do a raycast
            /// if the raycast hits a tower collider (show upgrade panel)
            /// if the raycast hits the ground( show the buy tower panel
            /// when you buy a tower, remove the collider and add tower 
            GameObject spawnedTower = Instantiate(towerPrefab);

            spawnedTower.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 5));
            var x = Mathf.Floor(spawnedTower.transform.position.x) + .5f;
            var y = Mathf.Floor(spawnedTower.transform.position.y) + .5f;
            spawnedTower.transform.position= new Vector3(x, y, 0);
            canPlace = false;
        }
    }
}
