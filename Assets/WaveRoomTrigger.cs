using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveRoomTrigger : MonoBehaviour
{
    public int maxEnemies = 2;
    public int waves = 1;
    public float spawnDelay = 2f;
    public GameObject[] enemyPrefabs;
    public Transform[] spawnPoints;

    private int currentEnemies;
    private int currentWave;
    private bool isTriggered;

    // Start is called before the first frame update
    void Start()
    {
        currentEnemies = maxEnemies;
    }

    public void EnemyKilled(GameObject enemy)
    {
        currentEnemies--;

        if (currentEnemies <= 0)
        {
            StartCoroutine(SpawnWave());
        }
    }

    private IEnumerator SpawnWave()
    {
        yield return new WaitForSeconds(spawnDelay);

        currentWave++;
        currentEnemies = maxEnemies;

        if (currentWave <= waves)
        {
            // Spawn new enemies
            for (int i = 0; i < maxEnemies; i++)
            {
                int prefabIndex = Random.Range(0, enemyPrefabs.Length);
                int spawnIndex = Random.Range(0, spawnPoints.Length);
                Instantiate(enemyPrefabs[prefabIndex], spawnPoints[spawnIndex].position, Quaternion.identity);
            }
        }
        else
        {
            // Trigger door opening, or whatever you want to happen
            Debug.Log("All waves complete!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isTriggered && other.CompareTag("Player"))
        {
            isTriggered = true;

            // Start the first wave
            StartCoroutine(SpawnWave());
        }
    }
}
