using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagers : MonoBehaviour
{
    public static GameManagers Instance { get; private set; }

    private Dictionary<int, int> enemiesRemainingByRoom = new Dictionary<int, int>();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateEnemiesRemaining(int roomNumber, int enemiesRemaining)
    {
        enemiesRemainingByRoom[roomNumber] = enemiesRemaining;
        CheckAllEnemiesDefeated();
    }

    private void CheckAllEnemiesDefeated()
    {
        bool allEnemiesDefeated = true;

        // Check if there are any enemies remaining in any room
        foreach (KeyValuePair<int, int> entry in enemiesRemainingByRoom)
        {
            if (entry.Value > 0)
            {
                allEnemiesDefeated = false;
                break;
            }
        }

        // If all enemies are defeated, do something (e.g. end game, display victory message, etc.)
        if (allEnemiesDefeated)
        {
            Debug.Log("All enemies have been defeated!");
        }
    }
}
