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

    public void TakeDamage(int damage)
    {
        health -= damage; 
        animator.SetTrigger("Hurt");

        if (health <= 0)
        {
            enemyName.GetComponent<EnemyMovement>().enabled = false;
            animator.SetBool("isDead", true);
            Invoke("Die", 2);
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
