using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float moveSpeed;
    public int patrolDestination;
    public Transform playerTransform;
    public bool isChasing;
    public float chaseDistance;
    private float originalScaleX;

    void Start()
    {
        // Retrieve the original X scale value
        originalScaleX = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing)
        {
            if(Vector2.Distance(transform.position, playerTransform.position) > chaseDistance)
            {
                isChasing = false;

                if (transform.position.x > playerTransform.position.x)
                {
                transform.localScale = new Vector3(originalScaleX, transform.localScale.y, transform.localScale.z);
                }

                if (transform.position.x < playerTransform.position.x)
                {
                transform.localScale = new Vector3(-originalScaleX, transform.localScale.y, transform.localScale.z);
                }
            }

            if (transform.position.x > playerTransform.position.x)
            {
                transform.localScale = new Vector3(originalScaleX, transform.localScale.y, transform.localScale.z);
                transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            }

            if (transform.position.x < playerTransform.position.x)
            {
                transform.localScale = new Vector3(-originalScaleX, transform.localScale.y, transform.localScale.z);
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            }
        }

        else
        {
            if (Vector2.Distance(transform.position, playerTransform.position) < chaseDistance)
            {
                isChasing = true;
            }
            if (patrolDestination == 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);

            if (Vector2.Distance(transform.position, patrolPoints[0].position) < .2f)
            {
                transform.localScale = new Vector3(-originalScaleX, transform.localScale.y, transform.localScale.z);
                patrolDestination = 1;
            }
            }

            if (patrolDestination == 1)
            {
                transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, moveSpeed * Time.deltaTime);

            if (Vector2.Distance(transform.position, patrolPoints[1].position) < .2f)
            {
                transform.localScale = new Vector3(originalScaleX, transform.localScale.y, transform.localScale.z);
                patrolDestination = 0;
            }
            }
        }     
    }
}
