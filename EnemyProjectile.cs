using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter2D(Collider2D collision)
   {
        if (collision.tag != "Enemy")
        {
          //  if(collision.GetComponent<>()!= null);
          //  {
          //      collision.GetComponent<>().DealDamge(damage);
            //}
             if(collision.tag =="Player")
            {
              PlayerStats.playerStats.DealDamge(damage);
            }
            Destroy(gameObject);
        }
   }
}
