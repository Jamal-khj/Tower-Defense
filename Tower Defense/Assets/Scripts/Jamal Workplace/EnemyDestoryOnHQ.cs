using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestoryOnHQ : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "HQ")
        {
            Destroy(gameObject);
        }
    }
}