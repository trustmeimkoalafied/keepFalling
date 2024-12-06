using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleWanderAI : MonoBehaviour
{
    public float moveSpeed = 2f;    // Movement speed
    public float changeDirectionTime = 3f; // Time to change direction
    private float directionTimer;
    private Vector3 moveDirection;

    void Start()
    {
        // Initialize direction timer
        directionTimer = changeDirectionTime;

        // Pick a random initial direction
        PickNewDirection();
    }

    void Update()
    {
        // Move the AI
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // Count down the timer
        directionTimer -= Time.deltaTime;

        // Change direction when the timer runs out
        if (directionTimer <= 0)
        {
            PickNewDirection();
            directionTimer = changeDirectionTime;
        }
    }

    // Picks a new random direction for the AI to move
    void PickNewDirection()
    {
        float randomX = Random.Range(-1f, 1f);
        float randomZ = Random.Range(-1f, 1f);

        // Normalize to ensure consistent speed in all directions
        moveDirection = new Vector3(randomX, 0, randomZ).normalized;
    }
}
