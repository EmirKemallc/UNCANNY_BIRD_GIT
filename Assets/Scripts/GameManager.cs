using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject startScreen;
    [SerializeField] private GameObject gameOverScreen;
    public AudioSource music;
    public AudioSource deathSound;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        Time.timeScale = 0f; 
    }

    private void Start()
    {
        startScreen.SetActive(true);
        gameOverScreen.SetActive(false);
    }

    public void StartGame()
    {
        Cursor.visible = false;
        startScreen.SetActive(false);
        gameOverScreen.SetActive(false);
        ScoreManager.Instance.ResetScore();
        Time.timeScale = 1f;
        music.Play();
    }

    public void OnPlayerDied()
    {
        Cursor.visible = true;
        gameOverScreen.SetActive(true);
        deathSound.Play();
        StartCoroutine(DeathRoutine());
        music.Stop();
        
    }

    private IEnumerator DeathRoutine()
    {
        
        yield return new WaitForSeconds(0.4f); 
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}