using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Jamal.Script;)

public class EnemyDestroyOnHQ : MonoBehaviour
{
    public GameObject enemyObject;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("HQ"))
        {
            Destroy(enemyObject);
        }
    }
}