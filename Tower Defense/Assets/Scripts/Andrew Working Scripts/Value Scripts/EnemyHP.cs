using UnityEngine;
using UnityEngine.SceneManagement;
//using Andrew.Script;)

public class EnemyHP : MonoBehaviour
{
    [SerializeField] private int hp = 2;
    [SerializeField] private int killCount;

    [SerializeField] private GameObject enemy;

    void Start()
    {
        killCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Death();

        if (killCount == 10)
        {
            SceneManager.LoadScene("Win");
        }
    }

    public void Death()
    {
        if (hp <= 0)
        {
            Destroy(enemy);
            killCount++;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            hp -= 1;
        }
    }
}