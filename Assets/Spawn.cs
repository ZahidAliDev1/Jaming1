using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject coinPrefab;
    public Vector3 spawnPosition;
    public float spawnRange = 5f;
    public float spawnInterval = 5f;

    private void Start()
    {
        StartCoroutine(SpawnCoins());
    }

    private IEnumerator SpawnCoins()
    {
        while (true)
        {
            Vector3 randomPosition = spawnPosition + new Vector3(Random.Range(-spawnRange, spawnRange), 0f, Random.Range(-spawnRange, spawnRange));
            Instantiate(coinPrefab, randomPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
