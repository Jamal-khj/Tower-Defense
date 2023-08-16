using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Vector3 mousePos;
    private Vector3 currentTowerSpawnLocation;

    private bool canPlace;
    private bool releasedButton;

    // Start is called before the first frame update
    void Start()
    {
        canPlace = false;
        releasedButton = true;
    }

    // Update is called once per frame
    void Update()
    {
        MouseInput();

        if (releasedButton == false && canPlace == true)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(mousePos), Vector2.zero);
            
            if (hit.transform.CompareTag("TowerPos"))
            currentTowerSpawnLocation = hit.transform.position;
            
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
}
