using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] private Transform enemyPrefab;
    // Start is called before the first frame update
    private void Start()
    {
        StartBattle();
    }

    // Update is called once per frame
    private void StartBattle()
    {
         if (enemyPrefab != null)
        {
            enemyPrefab.GetComponent<Spawner>().SpawnEnemy();
        }
        else
        {
            Debug.LogError("enemyTransform is not assigned!");
        }
    }
}
