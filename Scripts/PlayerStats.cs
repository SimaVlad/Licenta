using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats playerStats;

    public GameObject player;

    public float health;
    public float max_health = 100;


    private void Awake()
    {
        if (playerStats != null)
        {
            Destroy(playerStats);
        }
        else
        {
            playerStats = this;
        }
        DontDestroyOnLoad(this);
    }


    void Start()
    {
        health = max_health;
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        CheckDeath();
    }

    public void Heal(float heal)
    {
        health += heal;
        if(health > max_health)
        {
            health = max_health;
        }       
    }

    public void CheckDeath()
    {
        if (health <= 0)
        {
            print("destry player");
            Destroy(player);
        }
    }
}
