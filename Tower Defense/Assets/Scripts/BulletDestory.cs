using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestory : MonoBehaviour
{
    public GameObject Explosion;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Instantiate(Explosion, transform.position, Quaternion.identity);
        }

        if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }
}