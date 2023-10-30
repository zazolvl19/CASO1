using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; 
    public float spawnRate = 2f; 
    public float spawnRadius = 10f; 

    void Start()
    {
        
        InvokeRepeating("SpawnEnemy", 0f, spawnRate);
    }

    void SpawnEnemy()
    {
        
        Vector3 randomPosition = Random.insideUnitCircle * spawnRadius;
        Vector3 spawnPosition = new Vector3(randomPosition.x, randomPosition.y, 0f) + transform.position;

        
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
