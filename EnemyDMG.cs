using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDMG : MonoBehaviour
{
   public float health;
   public float maxHealth;

   void Start()
   {
        health = maxHealth;
   }  

   public void DealDamge(float damage)
   {
        health -= damage; 
        CheckDeath();
   }

   private void CheckOverheal() //unused for now if we ever decide to go for a sort of overshield mechanic this will help
   {
        if(health>maxHealth)
        {
            health = maxHealth;
        }
   }

   private void CheckDeath()
   {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
   }
}
