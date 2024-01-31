using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    [SerializeField] private GameObject PauseUI;

    public void StartScene()
    {
        SceneManager.LoadScene("Floppy_Bird");
    }

    public void RestartScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        SceneManager.LoadScene(currentSceneName);

        if (GameManager.Instance.IsPaused)
        {
            GameManager.Instance.IsPaused = false;
            Cursor.visible = false;
            Time.timeScale = 1f;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Resume()
    {
        GameManager.Instance.IsPaused = false;
        PauseUI.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1f;
    }
}
