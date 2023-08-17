using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Jamal.Script;)

public class BulletScript : MonoBehaviour
{
    public GameObject Enemy;
    private Rigidbody2D rb;
    public float Force;

    public GameObject bullet;
    
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       Enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy != null)
        {
            Vector2 direction = Enemy.transform.position - transform.position;
            rb.velocity = new Vector2(direction.x, direction.y).normalized * Force;
            
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rot + 180);
        }
    }
}
