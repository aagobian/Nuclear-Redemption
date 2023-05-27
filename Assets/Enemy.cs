using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float health = 10;
    public Animator animator;
    public GameObject enemyName;

    public void TakeDamage(int damage)
    {
        health -= damage; 
        animator.SetFloat("AHealth", health);

        if (health <= 0)
        {
            enemyName.GetComponent<EnemyMovement>().enabled = false;
            Invoke("Die", 1);
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
