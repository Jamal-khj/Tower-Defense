using System.Runtime.InteropServices;
using UnityEngine;

public class CostManager : MonoBehaviour
{
    PassiveManaTest coinvalue; 

    public float basicTowerCost = 5;

    void Awake()
    {
        coinvalue = GetComponent<PassiveManaTest>();
    }

    void Update()
    {
        DeductMoney(basicTowerCost);
    }

    public float DeductMoney(float cost)
    {
        float deductedAmount;
        coinvalue.coinSlider.value = coinvalue.currentAmount;
        deductedAmount = coinvalue.currentAmount - cost;
        return deductedAmount;
    }

}
