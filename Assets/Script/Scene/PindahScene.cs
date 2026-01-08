using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    // PANEL ABOUT (drag dari Inspector)
    public GameObject aboutPanel;

    // === BUTTON START ===
    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    // === BUTTON ABOUT ===
    public void OpenAbout()
    {
        if (aboutPanel != null)
            aboutPanel.SetActive(true);
    }

    public void CloseAbout()
    {
        if (aboutPanel != null)
            aboutPanel.SetActive(false);
    }

    // === BUTTON EXIT ===
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Keluar"); // cuma kelihatan di Editor
    }
}
