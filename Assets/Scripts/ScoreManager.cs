using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    private int _score;
    private int _highScore;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        
        _highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    public void AddScore(int amount = 1)
    {
        _score += amount;
        scoreText.text = "Skor: " + _score;

        if (_score > _highScore)
        {
            _highScore = _score;
            PlayerPrefs.SetInt("HighScore", _highScore);
            PlayerPrefs.Save(); 
        }
    
        
        highScoreText.text = "HighScore: " + _highScore;
    }

    public void ResetScore()
    {
        _score = 0;
        scoreText.text = "Skor: 0";
        highScoreText.text = "HighScore: " + _highScore;
    }
}