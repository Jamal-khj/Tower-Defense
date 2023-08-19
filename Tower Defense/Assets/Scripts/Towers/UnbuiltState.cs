using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnbuiltState : TowerBaseState
{
    //defining the methods in abstract state, with this state's unique logic
    public override void EnterState(TowerHandler tower)
    {
        Debug.Log("You're in the unbuilt state");
    }

    public override void UpdateState(TowerHandler tower)
    {
        if (releasedButton == false && canPlace == true)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.transform.CompareTag("TowerPos"))
            {
                currentTowerSpawnLocation = hit.transform.position;

                currentCollider = hit.collider;
                Debug.Log($"THE CURRENT POSITION IS {currentTowerSpawnLocation}");
                ShowOptionsPanel();
            }
        }

    }

}
