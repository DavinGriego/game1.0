using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
   public float damage;

   void OnTriggerEnter2D(Collider2D collision)
   {
        if (collision.name != "Player")
        {
            if(collision.GetComponent<EnemyDMG>()!= null);
            {
                collision.GetComponent<EnemyDMG>().DealDamge(damage);
            }
            Destroy(gameObject);
        }
   }
}
