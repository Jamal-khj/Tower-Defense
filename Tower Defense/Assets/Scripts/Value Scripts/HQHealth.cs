using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HQHealth : MonoBehaviour, IDamageable<int>
{
    [SerializeField] private float currentHP;
    [SerializeField] private float maxHP = 20f;
    [SerializeField] private int dmgValue = 1;
    public Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;

    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.maxValue = maxHP;
        healthSlider.value = currentHP;
        GameOver();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            TakeDamage(dmgValue);
        }
    }

    public void TakeDamage(int damage)
    {
        float totalDamage;
        
        currentHP -= damage;

        totalDamage = damage;
    }

    public void GameOver()
    {
        if (currentHP <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
