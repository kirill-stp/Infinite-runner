using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnPoints;
    [SerializeField] private GameObject spikePrefab;
    [SerializeField] private float spawnColdown;
    [SerializeField] private float difficulty;
    
    private float currentTime = 0;

    private void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= spawnColdown)
        {
            SpawnSpikes();
            currentTime = 0;
        }
    }

    private void SpawnSpikes()
    {
        int notSpawned = Random.Range(0, spawnPoints.Length);
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (Random.Range(0,1) < difficulty && i != notSpawned)
            {
                Instantiate(spikePrefab, spawnPoints[i].transform);
            }
        }
    }
}
