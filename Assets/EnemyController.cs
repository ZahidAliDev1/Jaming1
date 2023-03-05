using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{


    public Transform player;
    public float speed;

    void Update()
    {
        // Get the direction from the enemy to the player
        Vector3 direction = player.position - transform.position;

        // Normalize the direction vector so that it has a magnitude of 1
        direction.Normalize();

        // Calculate the enemy's new position by moving in the direction of the player at the specified speed
        Vector3 newPosition = transform.position + direction * speed * Time.deltaTime;

        // Set the enemy's new position
        transform.position = newPosition;

        // Rotate the enemy to face the player's position
        transform.LookAt(player.position);
    }


}
