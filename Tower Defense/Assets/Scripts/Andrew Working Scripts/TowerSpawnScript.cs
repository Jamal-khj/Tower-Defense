using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class TowerSpawnScript : MonoBehaviour
{
    public GameObject towerPrefab;
    private Vector3 mousePos;
    private bool canPlace;
    private bool releasedButton;
    public GameObject optionsPanel;
    private Vector3 currentTowerSpawnLocation;

    private void Awake()
    {
        optionsPanel.SetActive(false);
    }


    void Start()
    {
        canPlace = false;
        releasedButton = true;
    }

    void Update()
    {
        MouseInput();
        if (releasedButton == false && canPlace == true)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.transform.tag == "TowerPos")
            {
                currentTowerSpawnLocation = hit.transform.position;
                Debug.Log(currentTowerSpawnLocation + "THIS IS THE CURRENT POSITION!!");
                ShowOptionsPanel();
            }
        }
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
        GameObject spawnedTower = Instantiate(towerPrefab, currentTowerSpawnLocation, Quaternion.identity);
        optionsPanel.SetActive(false);
        canPlace = false;
    }

    public void ShowOptionsPanel()
    {
        //If you want you can play animations for panels fading in
        optionsPanel.SetActive(true);
    }

    /// do a raycast
    /// if the raycast hits a tower collider (show upgrade panel)
    /// if the raycast hits the ground( show the buy tower panel
    /// when you buy a tower, remove the collider and add tower 
    //spawnedTower.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 5));
    //spawnedTower.transform.position = Camera.main.ScreenToWorldPoint();
    //var x = Mathf.Floor(spawnedTower.transform.position.x) + .5f;
    //var y = Mathf.Floor(spawnedTower.transform.position.y) + .5f;
    //spawnedTower.transform.position = new Vector3(x, y, 0);
}
