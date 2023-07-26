using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour, IPooledBullet
{
    public GameObject Enemy;
    private Rigidbody2D rb;
    public float Force;
    
    // Start is called before the first frame update
    public void OnBulletSpawn()
    {
        rb = GetComponent<Rigidbody2D>();
        
        Vector2 direction = Enemy.transform.position - transform.position;

        rb.velocity = new Vector2(direction.x, direction.y).normalized * Force;
    }
}
