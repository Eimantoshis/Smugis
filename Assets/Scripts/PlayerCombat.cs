using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public Animator animator;
    private float nextAttack;
    private float attackRate = 0.75f;
    

    void Update()
    {


        
            if (Input.GetKeyDown(KeyCode.Mouse0) && transform.parent.gameObject.CompareTag("Zaidejas") && Time.time >=nextAttack)
            {
                Attack();
            nextAttack = Time.time + attackRate;
            }



        
    }
    void Attack()
    {
        
        
 animator.SetTrigger("Mojis");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().EnemyTakeDamage(100);
           

        }
    }
        
           
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
