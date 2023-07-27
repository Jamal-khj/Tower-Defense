using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestory : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }
}