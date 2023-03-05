using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BombSpawner : MonoBehaviour, IPointerDownHandler
{
    public GameObject bombPrefab;
    public Transform spawnPosition;

  


    public void OnPointerDown(PointerEventData eventData)
    {
        SpawnBomb();
    }



    public void SpawnBomb()
    {
        Instantiate(bombPrefab, spawnPosition.position, Quaternion.identity);
    }


}

