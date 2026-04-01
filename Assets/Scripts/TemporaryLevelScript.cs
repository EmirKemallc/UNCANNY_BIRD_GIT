using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TemporaryLevelScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
