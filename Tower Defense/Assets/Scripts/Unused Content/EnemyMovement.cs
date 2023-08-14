using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject PointA;
    public GameObject PointB;
    private Rigidbody2D rb;
    private Transform CurrentPoint;
    public float Speed;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CurrentPoint = PointB.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = CurrentPoint.position - transform.position;

        if(CurrentPoint == PointB.transform)
        {
            rb.velocity = new Vector2(Speed, 0);
        }
    }
}
