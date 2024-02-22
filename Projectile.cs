using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
   public float damage;

   /*void OnTriggerEnter2D(Collider2D collision)
   {
        if (collision.name != "Player")
        {
            if(collision.GetComponent<EnemyDMG>() != null)
            {
                collision.GetComponent<EnemyDMG>().DealDamge(damage);
            }
            Destroy(gameObject);
        }
   }*/
   void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collision is not with the player
        if (collision.CompareTag("Player"))
        {
            return; // Exit the method if colliding with the player
        }

        // Check if the collided object has an EnemyDMG component
        EnemyDMG enemy = collision.GetComponent<EnemyDMG>();
        if (enemy != null)
        {
            // Deal damage to the enemy
            enemy.DealDamge(damage);
        }

        // Destroy the projectile regardless of the collision
        Destroy(gameObject);
    }
}
