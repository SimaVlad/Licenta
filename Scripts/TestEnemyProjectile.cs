using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyProjectile : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == null)
        {
            throw new System.ArgumentNullException(nameof(collision));
        }

        print(collision.tag);
        print(gameObject.name+"123");
        if (collision.tag != "Enemy")
        {
            if(collision.tag == "Player")
            {
                PlayerStats.playerStats.DealDamage(damage);
                print(gameObject.name);
                Destroy(gameObject);
            }

        }
    }
}
