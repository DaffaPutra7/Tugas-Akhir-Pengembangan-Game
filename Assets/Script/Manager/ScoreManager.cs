using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int currentScore = 0;
    private bool targetReached = false; 

    void Start()
    {
        currentScore = 0;
        UpdateScoreUI();
    }

    public void AddScore(int amount)
    {
        currentScore += amount;
        UpdateScoreUI();

        if (currentScore >= 100 && !targetReached)
        {
            Level3Manager level3 = FindFirstObjectByType<Level3Manager>();

            if (level3 != null)
            {
                targetReached = true; 
                level3.StartBossPhase();
            }
            else
            {
                GameOverManager gm = FindFirstObjectByType<GameOverManager>();
                if (gm != null)
                {
                    gm.TriggerWin();
                }
            }
        }
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + currentScore.ToString();
        }
    }
}