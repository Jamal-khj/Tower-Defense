using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Jamal.Script;)

public class BulletDestroy : MonoBehaviour
{
    public GameObject Explosion;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
        
        if (collision.gameObject.tag == "HQ")
        {
            Destroy(gameObject);
        }
    }
}