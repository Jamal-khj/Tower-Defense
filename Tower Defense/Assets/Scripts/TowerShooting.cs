using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShooting : MonoBehaviour
{
    public GameObject Bullet;
    public Transform BulletPos;

    public float Timer;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > 2)
        {
            Timer = 0;
            Shoot();
        }  
    }

    void Shoot()
    {
        Instantiate(Bullet, BulletPos.position, Quaternion.identity);
    }
}