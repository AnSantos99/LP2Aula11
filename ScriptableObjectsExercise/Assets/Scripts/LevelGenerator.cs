using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab = null;

    [SerializeField]
    private LevelSpec levelSpec = null;

    private void Awake()
    {
        foreach (Vector2 pos in levelSpec.EnemySpawnPoints)
            Instantiate(enemyPrefab, pos, Quaternion.identity);
        
    }
}
