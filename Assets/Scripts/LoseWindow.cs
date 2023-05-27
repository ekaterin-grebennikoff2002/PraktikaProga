using TMPro;
using UnityEngine;

public class LoseWindow : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreTXT;

    public void PlayerLose()
    {
        int score = ScoreManager.Instance.score;
        scoreText.text = score.ToString();
        int bestScore = PlayerPrefs.GetInt("BestScore");
        if (score > bestScore)
        {
            bestScore = score;
        }

        bestScoreTXT.text = bestScore.ToString();
        PlayerPrefs.SetInt("BestScore", bestScore);
    }

}
