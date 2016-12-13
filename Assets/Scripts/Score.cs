using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public GUIText scoreText;
    private int score = 0;

    private void Start()
    {
        UpdateScore();
    }

    public void AddScore(int newScore)
    {
        score += newScore;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score.ToString();
    }

}
