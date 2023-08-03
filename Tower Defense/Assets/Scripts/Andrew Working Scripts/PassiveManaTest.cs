using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassiveManaTest : MonoBehaviour
{

    //attached to currency bar UI

    public Slider coinSlider;
    public float currentAmount;
    public int coinMax;
    // Start is called before the first frame update
    void Start()
    {
        coinSlider = GetComponent<Slider>();
        currentAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentAmount += Time.deltaTime;
        coinSlider.value = currentAmount;
        coinSlider.maxValue = coinMax;
    }
}
