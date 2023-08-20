using UnityEngine;
using UnityEngine.SceneManagement;
//using Andrew.Script;)

public class EnemyHP : MonoBehaviour, IDamageable<int>
{
    [SerializeField] private int hp;
    [SerializeField] private int killCount;
    [SerializeField] private int dmgValue = 2;
    [SerializeField] private int dmgValueRapid = 1;
    [SerializeField] private int dmgValueSlow = 4;

    [SerializeField] private GameObject enemy;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] AudioClip deathSound;
    public AudioSource audioPlayer;
    


    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
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
            Debug.Log("DEATH");
            audioSource.PlayOneShot(deathSound, 1f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            TakeDamage(dmgValue);
        }
        
        if (collision.gameObject.tag == "Bullet Rapid")
        {
            TakeDamage(dmgValue);
        }

        if (collision.gameObject.tag == "Bullet Slow")
        {
            TakeDamage(dmgValue);
        }
    }

    public void TakeDamage(int damage)
    {
        float totalDamage;

            hp -= damage;

            totalDamage = damage;
    }
}