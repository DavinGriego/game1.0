using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
   public static PlayerStats playerStats;
   
   public GameObject player; 
   public Text healthText;
   public Slider PHealthSlider;

   public float health;
   public float maxHealth;

   void Awake()
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
        health = maxHealth;//starts at max health
        PHealthSlider.value=1;
        SetHealthUI();
   }  

   public void DealDamge(float damage)//takes damage
   {
        health -= damage; 
        CheckDeath();
        PHealthSlider.value = CalculateHealthPercentage();
        SetHealthUI();
   }

   public void HealCharacter(float heal)
   {
        health += heal;
        CheckOverheal();
        PHealthSlider.value = CalculateHealthPercentage();
        SetHealthUI();
   }

   private void SetHealthUI()
   {
        PHealthSlider.value = CalculateHealthPercentage();
        healthText.text = Mathf.Ceil(health).ToString() + " / " + Mathf.Ceil(maxHealth).ToString();
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
            Destroy(player);
        }
   }

   float CalculateHealthPercentage()
   {
     return health/maxHealth;
   }
}
