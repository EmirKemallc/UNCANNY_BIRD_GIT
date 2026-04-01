using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private bool _scored = false;
    public AudioSource scoreSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !_scored)
        {
            _scored = true;
            ScoreManager.Instance.AddScore();
            scoreSound.Play();
        }
    }
}