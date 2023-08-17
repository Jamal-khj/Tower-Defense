using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Jamal.Script;)

public class Spawner : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject[] EnemyPrefabs;

    public float SpawnTimer;
    public float FixedTimer;
    
    // Start is called before the first frame update
    void Start()
    {

        SpawnTimer = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer -= Time.deltaTime;

        // Spawn enemies
        if(SpawnTimer <= 0.0f)
        {
            print("hello");

            SpawnTimer = FixedTimer;
            int EnemySpawn = Random.Range(0, EnemyPrefabs.Length);
            int SpawnLocation = Random.Range(0, SpawnPoints.Length);
            Instantiate(EnemyPrefabs[EnemySpawn], SpawnPoints[SpawnLocation].position, transform.rotation);


        }
    }
}