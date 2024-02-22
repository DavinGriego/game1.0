using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttackj : MonoBehaviour
{
    public Transform AttackArea;
    public float attackRange= 0.5f;
    public LayerMask enemyLayer;
    public int attackDamage = 40;
    public float minDamage;
    public float maxDamage;
    public float projectileForce;
    public GameObject sword;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Attack();
        }
    }
    
    void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackArea.position, attackRange, enemyLayer);

        //foreach(Collider2D enemy in hitEnemies)
        //{
            //Debug.Log("Rip ur dick of on stream"); testing :)
            //enemy.GetComponent<EnemyDMG>().DealDamge(attackDamage);
            //sword.GetComponent<EnemyDMG>().DealDamage(attackDamage);
            //GameObject sword.GetComponent<EnemyDMG>().DealDamge(attackDamage);
            //Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Vector2 myPos = transform.position;
            //Vector2 direction = (mousePos - myPos).normalized;
            //sword.GetComponent<Rigidbody2D>().velocity=direction;
            //spell.GetComponent<Projectile>().damage = Random.Range(minDamage, maxDamage);
        //}
    }

    void OnDrawGizmosSelected()
    {
        if(AttackArea == null)
            return;
    
        Gizmos.DrawWireSphere(AttackArea.position, attackRange);
    }
}
