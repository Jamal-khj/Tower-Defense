using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingHealthBar : MonoBehaviour
{
    [SerializeField] private Slider HealthBar;

    public void UpdateHealthBar(float CurrentHealth,  float MaxHealth)
    {
            HealthBar.value = CurrentHealth / MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
