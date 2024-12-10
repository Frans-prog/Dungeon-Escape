using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RoomTrigger : MonoBehaviour
{
    public GameObject[] doors; // Array of door game objects to close when player enters
    public string[] enemyTags; // Array of tags to identify all enemies in the room
    public int numberOfEnemies; // Total number of enemies in the room
    private int enemiesRemaining; // Counter for the number of enemies remaining in the room

    private bool doorClosed = false; // Flag to track if door has been closed

    public GameObject[] enemyPrefabs; // Array of enemy prefabs to spawn
    public Transform[] spawnPoints; // An array of spawn points where the enemies will spawn
    private bool enemySpawned = false; // Flag to track if enemy has been spawned

    
    
    void Start()
    {
        // Open all doors at the start of the game
        foreach (GameObject door in doors)
        {
            door.SetActive(false);
        }

        // Count the number of enemies in the room
        enemiesRemaining = numberOfEnemies;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (!doorClosed) // Only close door if it hasn't been closed already
            {
                foreach (GameObject door in doors)
                {
                    door.SetActive(true);
                }
                
                if (!enemySpawned)
                {
                    // Create a list of available spawn points
                    List<Transform> availableSpawnPoints = new List<Transform>(spawnPoints);

                    for (int i = 0; i < numberOfEnemies; i++)
                    {
                        // Choose a random enemy prefab to spawn
                        GameObject enemyPrefab = enemyPrefabs[UnityEngine.Random.Range(0, enemyPrefabs.Length)];

                        // Choose a random available spawn point
                        int spawnIndex = UnityEngine.Random.Range(0, availableSpawnPoints.Count);
                        Transform spawnPoint = availableSpawnPoints[spawnIndex];
                        availableSpawnPoints.RemoveAt(spawnIndex);

                        // Instantiate the enemy at the spawn point
                        GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
                        enemy.transform.SetParent(spawnPoint.parent); // Set the parent of the enemy to the parent of the spawn point

                        // Pass a reference to this RoomTrigger script to the enemy script
                        EnemyHealth enemyHealth = enemy.GetComponent<EnemyHealth>();
    if (enemyHealth != null)
    {
        enemyHealth.roomTrigger = this;
    }
                         BossHealth bossHealth = enemy.GetComponent<BossHealth>();
                            if (bossHealth != null)
                            {
                                bossHealth.roomTrigger = this;
                            }
                        // Choose a random tag for the enemy
                        enemy.tag = enemyTags[UnityEngine.Random.Range(0, enemyTags.Length)];
                    }
                    enemySpawned = true;
                }
                Debug.Log("Player entered the room");
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited the room");
        }
    }

    public void EnemyKilled(GameObject enemyObject)
    {
        if (Array.IndexOf(enemyTags, enemyObject.tag) != -1)
        {
            enemiesRemaining--; // Decrement the enemies
    
            // If all enemies have been killed, open the doors
            if (enemiesRemaining == 0)
            {
                foreach (GameObject door in doors)
                {
                    door.SetActive(false);
                }
                doorClosed = true;
                Debug.Log("All enemies have been killed. Doors are open.");
            }
            else // Otherwise, there are still enemies remaining
            {
                Debug.Log("An enemy was killed, but there are still enemies left in the room.");
            }
        }
    }
}
