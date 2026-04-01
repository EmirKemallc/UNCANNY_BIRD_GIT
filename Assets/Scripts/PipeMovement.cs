using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private ObstacleSettings obstacleData;

    private void Update()
    {
        transform.Translate(Vector3.back * obstacleData.moveSpeed * Time.deltaTime);
    }
}