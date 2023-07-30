using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatBar : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public void UpdateBar(float CurrentValue, float MaxValue)
    {
        slider.value = CurrentValue/MaxValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}