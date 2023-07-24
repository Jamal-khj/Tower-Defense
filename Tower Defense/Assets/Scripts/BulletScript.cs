using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject Enemy;
    private Rigidbody2D rb;
    public float Force;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       // Enemy = GameObject.FindGameObjectWithTag("Enemy");

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Enemy.transform.position - transform.position;

        rb.velocity = new Vector2(direction.x, direction.y).normalized * Force;

    }
}
