using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int score;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void updateScore(int scoreValue)
    {
        score = score + scoreValue;
        scoreText.SetText("Score: " + score);
    }
}