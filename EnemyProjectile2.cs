using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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
            Destroy(gameObject);
        }
   }
}
