using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletPooler : MonoBehaviour
{
    public Dictionary<string, Queue<GameObject>> bulletDictionary;

    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject bulletPrefab;
        public int size;
    }

    #region Singleton

    public static BulletPooler Instance;

    private void Awake()
    {
        Instance = this;
    }

    #endregion

    public List<Pool> bulletList;

    // Start is called before the first frame update
    void Start()
    {
        bulletDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach (Pool pool in bulletList)
        {
            Queue<GameObject> bulletPool = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.bulletPrefab);
                obj.SetActive(false);
                bulletPool.Enqueue(obj);
            }
            bulletDictionary.Add(pool.tag, bulletPool);
        }

        
    }

    public GameObject SpawnFromPool(string tag, Vector2 position, Quaternion rotation)
    {
        if (!bulletDictionary.ContainsKey(tag))
        {
            Debug.Log("Object with tag" + tag + "doesn't exist");
            return null;
        }

        GameObject bulletToSpawn = bulletDictionary[tag].Dequeue();

        bulletToSpawn.SetActive(true);
        bulletToSpawn.transform.position = position;
        bulletToSpawn.transform.rotation = rotation;

        IPooledBullet pooledBullet = bulletToSpawn.GetComponent<IPooledBullet>();

        if (pooledBullet != null)
        {
            pooledBullet.OnBulletSpawn();
        }

        bulletDictionary[tag].Enqueue(bulletToSpawn);

        return bulletToSpawn;
    }
}
