using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{

    // BUTTON START
    public void StartGame()
    {
        SceneManager.LoadScene("HalamanLevel");
    }

    // BUTTON ABOUT
    public void OpenAbout()
    {
        SceneManager.LoadScene("HalamanAbout");
    }

    // BUTTON BACK(dari About)
    public void BackToMenu()
    {
        SceneManager.LoadScene("HalamanUtama");
    }

    // === BUTTON EXIT ===
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Keluar");
    }
}
