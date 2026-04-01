using UnityEngine;

[CreateAssetMenu(fileName = "NewScriptableObjectScript", menuName = "Scriptable Objects/NewScriptableObjectScript")]
public class ObstacleSettings : ScriptableObject
{
    [Header("Pipe Ayarları")]
    public float moveSpeed = 5f;
    public float spawnInterval = 2f;
    public float gapSize = 3f;
    public float destroyZ = 10f;

    [Header("Zorluk")]
    public float speedIncreaseRate = 0.1f;
    public float minSpawnInterval = 0.8f;
}
