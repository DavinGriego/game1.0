using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDMG : MonoBehaviour
{
   public float health;
   public float maxHealth;

   public GameObject healthBar;
   public Slider healthBarSlider;

   void Start()
   {
        health = maxHealth;
   }  

   public void DealDamge(float damage)
   {
        healthBar.SetActive(true);
        health -= damage; 
        CheckDeath();
        healthBarSlider.value = CalculateHealthPercentage();
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

   private float CalculateHealthPercentage()
   {
     return (health / maxHealth);
   }
}
