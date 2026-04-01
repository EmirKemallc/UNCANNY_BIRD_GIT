using System;
using UnityEngine;
using System.Collections;
using PatternMethod;
using Random = UnityEngine.Random;

// SRP: Sadece pipe spawn zamanlamasından sorumlu
public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private ObstacleSettings obstacleData;
    [SerializeField] private float minY = -2f;
    [SerializeField] private float maxY = 2f;
    [SerializeField] private float spawnZ = -20f;

    private void Start()
    {
        StartCoroutine(SpawnRoutine());
    }
    
    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            SpawnPipe();
            yield return new WaitForSeconds(obstacleData.spawnInterval);
        }
    }

    private void SpawnPipe()
    {
        GameObject pipe = PoolManager.Instance.Get("PipePrefab");
        if (pipe == null) return;

        float randomY = Random.Range(minY, maxY);
        pipe.transform.position = new Vector3(1.3f, randomY, spawnZ);
    }
}