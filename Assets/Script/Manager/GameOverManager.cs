using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [Header("UI Components")]
    public GameObject gameOverText;
    public GameObject winnerText;  
    public GameObject restartButton;

    public void TriggerGameOver()
    {
        gameOverText.SetActive(true); 
        restartButton.SetActive(true);
        Time.timeScale = 0f;          
    }

    public void TriggerWin()
    {
        winnerText.SetActive(true);     
        restartButton.SetActive(true);  
        Time.timeScale = 0f;           
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}