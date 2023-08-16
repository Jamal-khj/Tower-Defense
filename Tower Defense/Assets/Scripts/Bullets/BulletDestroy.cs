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
            DestroyObject();
        }

        if (collision.gameObject.tag == "Boundary")
        {
            DestroyObject();
        }
        
        if (collision.gameObject.tag == "HQ")
        {
            DestroyObject();
        }
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}