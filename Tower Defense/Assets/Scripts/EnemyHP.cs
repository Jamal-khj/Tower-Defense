using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] private int hp = 2;
    [SerializeField] private GameObject enemy;

    // Update is called once per frame
    void Update()
    {
        Death();
    }

    public void Death()
    {
        if (hp <= 0)
        {
            Destroy(enemy);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            hp -= 1;
        }
    }
}