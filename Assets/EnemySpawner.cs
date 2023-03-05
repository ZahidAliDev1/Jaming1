using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int maxEnemies = 5;
    public float spawnDelay = 5f;
    public Transform[] spawnPositions;

    private int currentEnemies = 0;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (currentEnemies < maxEnemies)
        {
            yield return new WaitForSeconds(spawnDelay);

            if (currentEnemies < maxEnemies)
            {
                Transform spawnPosition = spawnPositions[Random.Range(0, spawnPositions.Length)];
                GameObject g = Instantiate(enemyPrefab, spawnPosition.position, spawnPosition.rotation);
                g.GetComponent<EnemyController>().player = GameObject.FindGameObjectWithTag("Player").transform;
                currentEnemies++;
            }
        }
    }
}
