using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void LoadLevel1()
    {
        Debug.Log("SAYA MENEKAN TOMBOL LEVEL 1"); 
        SceneManager.LoadScene("MainGames");
    }

    public void LoadLevel2()
    {
        Debug.Log("SAYA MENEKAN TOMBOL LEVEL 2"); 
        SceneManager.LoadScene("MainGames [ Level 2 ]");
    }

    public void LoadLevel3()
    {
        Debug.Log("SAYA MENEKAN TOMBOL LEVEL 3"); 
        SceneManager.LoadScene("MainGames [ Level 3]");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("HalamanUtama");
    }
}