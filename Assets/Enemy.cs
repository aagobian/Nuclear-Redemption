using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 10;
    public Animator animator;
    public GameObject enemyName;
    private EnemyMovement enemyMovement;
    private bool isDying = false;

    private void Start()
    {
        // Get the reference to the EnemyMovement component
        enemyMovement = GetComponent<EnemyMovement>();
    }

    public void TakeDamage(int damage)
    {
        if (isDying) return;
        
        health -= damage; 
        animator.SetTrigger("Hurt");

        if (health <= 0)
        {
            isDying = true; 
            animator.SetBool("isDead", true);
            if (enemyMovement != null)
            {
                enemyMovement.enabled = false;
            }
            Invoke("Die", 2);
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
