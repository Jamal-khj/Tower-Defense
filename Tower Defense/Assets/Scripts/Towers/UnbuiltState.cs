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
        
    }

}
