using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f; 

    public float xLimit = 2.5f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xLimit, xLimit);

        Vector2 spawnPos = new Vector2(randomX, 6f);

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}