using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] private int hp = 10;
    private GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy.GetComponent<GameObject>();
    }

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            hp -= 3;
        }
    }
}