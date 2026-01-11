using UnityEngine;
using System.Collections;

public class Level3Manager : MonoBehaviour
{
    [Header("Pengaturan Musuh Kecil")]
    public GameObject[] smallEnemyPrefabs;
    public float spawnInterval = 1.5f;
    public float xLimit = 2.5f;

    [Header("Pengaturan Boss")]
    public GameObject bossObject;
    public GameObject bossHealthTextUI;

    private bool isBossSpawned = false;

    void Start()
    {
        if (bossObject != null) bossObject.SetActive(false);
        if (bossHealthTextUI != null) bossHealthTextUI.SetActive(false);

        StartCoroutine(SpawnWaveRoutine());
    }

    IEnumerator SpawnWaveRoutine()
    {
        while (!isBossSpawned)
        {
            SpawnSmallEnemy();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnSmallEnemy()
    {
        if (smallEnemyPrefabs.Length == 0) return;

        int randomIndex = Random.Range(0, smallEnemyPrefabs.Length);
        GameObject selectedEnemy = smallEnemyPrefabs[randomIndex];

        float randomX = Random.Range(-xLimit, xLimit);
        Vector2 spawnPos = new Vector2(randomX, 6f);

        Instantiate(selectedEnemy, spawnPos, Quaternion.identity);
    }

    public void StartBossPhase()
    {
        if (!isBossSpawned)
        {
            isBossSpawned = true; 
            StartCoroutine(SpawnBossDelay());
        }
    }

    IEnumerator SpawnBossDelay()
    {
        yield return new WaitForSeconds(3f);

        if (bossObject != null)
        {
            Debug.Log("BOSS DATANG!");
            bossObject.SetActive(true); 

            if (bossHealthTextUI != null)
                bossHealthTextUI.SetActive(true); 
        }
    }
}