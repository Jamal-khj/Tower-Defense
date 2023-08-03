using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HQHealth : MonoBehaviour
{
    [SerializeField] private float currentHP;
    [SerializeField] private float maxHP;
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
            TakeDamage();
        }
    }

    public void TakeDamage()
    {
        currentHP -= 2;
    }

    public void GameOver()
    {
        if (currentHP <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
