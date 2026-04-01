using UnityEngine;
using PatternMethod;

public class PipeRecycler : MonoBehaviour
{
    [SerializeField] private ObstacleSettings obstacleData;

    private void Update()
    {
        if (transform.position.z < -obstacleData.destroyZ)
        {
            PoolManager.Instance.Return(gameObject);
        }
    }
}