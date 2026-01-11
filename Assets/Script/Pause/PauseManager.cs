using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [Header("UI Components")]
    public GameObject pausePanel; // Panel menu yang muncul saat pause

    // Fungsi untuk tombol Pause (Pojok Kanan Atas)
    public void PauseGame()
    {
        pausePanel.SetActive(true); // Munculkan panel
        Time.timeScale = 0f;        // Bekukan waktu game
    }

    // Fungsi untuk tombol Resume (Lanjut Main)
    public void ResumeGame()
    {
        pausePanel.SetActive(false); // Sembunyikan panel
        Time.timeScale = 1f;         // Jalankan waktu lagi
    }

    // Fungsi untuk tombol Back to Menu
    public void BackToMenu()
    {
        Time.timeScale = 1f; // PENTING! Balikin waktu ke normal sebelum pindah scene
        SceneManager.LoadScene("HalamanUtama"); // Pastikan nama scene menu kamu benar
    }
}