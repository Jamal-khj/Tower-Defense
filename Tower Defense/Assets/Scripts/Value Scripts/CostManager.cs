using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostManager : MonoBehaviour
{
    PassiveManaTest coinvalue; 

    public float towerCost = 5;

    void Update()
    {
        DeductMoney(towerCost);
    }

    public float DeductMoney(float cost)
    {
        cost -= coinvalue.currentAmount;
        return cost;
    }

}
