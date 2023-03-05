using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject playerPrefab; // The player prefab to spawn

    void Start()
    {
        // Spawn the player at the starting position
        Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }
}

