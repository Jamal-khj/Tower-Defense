using UnityEngine;

public class CostManager : MonoBehaviour
{
    public PassiveManaTest coinvalue;

    public float basicTowerCost = 5;
    public float rapidFireCost = 10;
    public float heavyFireCost = 15;

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
        float postValue;
        coinvalue.coinSlider.value = coinvalue.currentAmount;
        postValue = coinvalue.currentAmount - cost;
        return postValue;
    }

}
