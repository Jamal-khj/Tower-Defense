using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private GameObject Enemy;
    private Rigidbody2D rb;
    public float Force;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Enemy = GameObject.FindGameObjectWithTag("Enemy");

        Vector2 direction = Enemy.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * Force; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
