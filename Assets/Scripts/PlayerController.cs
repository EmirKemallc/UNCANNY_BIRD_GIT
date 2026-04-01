using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f;
    public AudioSource jumpSound;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) & Time.timeScale != 0)
        {
            _rb.linearVelocity = Vector3.zero;
            _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpSound.Play();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Obstacle"))
        {
            GameManager.Instance.OnPlayerDied();
        }
    }
}