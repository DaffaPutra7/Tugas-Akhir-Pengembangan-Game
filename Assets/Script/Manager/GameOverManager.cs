using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [Header("UI Components")]
    public GameObject gameOverText;
    public GameObject winnerText;   

    [Header("Buttons")]
    public GameObject restartButton;
    public GameObject nextButton;    
    public GameObject backButton;    

    public void TriggerGameOver()
    {
        gameOverText.SetActive(true);

        if (restartButton != null) restartButton.SetActive(true);
        if (backButton != null) backButton.SetActive(true);
        if (nextButton != null) nextButton.SetActive(false);

        Time.timeScale = 0f; 
    }

    public void TriggerWin()
    {
        winnerText.SetActive(true);

        if (nextButton != null) nextButton.SetActive(true);
        if (backButton != null) backButton.SetActive(true);
        if (restartButton != null) restartButton.SetActive(false);

        Time.timeScale = 0f; 
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("HalamanUtama");
    }

    public void LoadNextLevel()
    {
        Time.timeScale = 1f; 

        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("Game Tamat! Kembali ke Menu.");
            SceneManager.LoadScene("HalamanUtama");
        }
    }
}