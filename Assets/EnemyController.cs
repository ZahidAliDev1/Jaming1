using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{



    public Transform player; // Reference to the player object
    public float speed = 5f; // The speed at which the enemy moves towards the player

    private bool isPaused = false; // Flag to check if the game is paused

    void Start()
    {

   
        // Find the player object by its tag
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Check if the game is paused
        if (Time.timeScale == 0)
        {
            isPaused = true;
            return;
        }
        else
        {
            isPaused = false;
        }

        // Move the enemy towards the player
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

  
}
