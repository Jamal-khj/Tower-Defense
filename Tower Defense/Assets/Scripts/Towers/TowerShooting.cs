using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Jamal.Script;)

public class TowerShooting : MonoBehaviour
{
    public BulletScript bulletObj;
    public Transform bulletPos;

    public List<GameObject> enemies;

    public float Timer;

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > 0.5f)
        {
            Timer = 0;

            if (enemies.Count > 0)
            {
                Shoot();
            }
        }  
    }

    void Shoot()
    {
       var bullet = Instantiate(bulletObj, bulletPos.position, Quaternion.identity);
       bullet.Enemy = enemies[0];
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemies.Add(collision.gameObject);
        //add this object to the list
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        enemies.Remove(collision.gameObject);
    }

}