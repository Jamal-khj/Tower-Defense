using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    /// <summary>
    /// This script temporarily replaces TowerShooting and BulletScript
    /// </summary>


    void FixedUpdate()
    {
        BulletPooler.Instance.SpawnFromPool("Bullet", transform.position, Quaternion.identity);
    }

}
