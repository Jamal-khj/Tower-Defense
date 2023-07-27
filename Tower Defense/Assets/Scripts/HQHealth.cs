using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HQHealth : MonoBehaviour
{
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;
    [SerializeField] private int enemyDamage;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

        }
    }



}
