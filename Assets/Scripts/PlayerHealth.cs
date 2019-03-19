using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] float maxHealth;
    [SerializeField] float currentHealth;
    [SerializeField] float enemyDamage = 5f;
    public Slider healthBar;
    public bool notDead = true;

    void Start()
    {
        maxHealth = 20f;
        currentHealth = maxHealth;

        healthBar.value = CalculateHealth();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            DealDamage(6);
        }
    }

    public void DealDamage(float damageValue)
    {
        currentHealth -= damageValue;
        healthBar.value = CalculateHealth();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    float CalculateHealth()
    {
        return currentHealth / maxHealth;
    }

    void Die()
    {
        notDead = false;
        FindObjectOfType<PlayerShooting>().Stop();
        currentHealth = 0; 
        Debug.Log("You are dead");
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            GetComponent<PlayerHealth>().DealDamage(enemyDamage);
            Debug.Log("Collision");
        }
        else
        {
            Debug.Log("no collision");
        }
    }
}
