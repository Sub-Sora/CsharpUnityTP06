using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    [SerializeField] GameObject PauseUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!GameManager.Instance.IsPaused)
            {
                GamePaused();
            }
        }
    }

    private void GamePaused()
    {
        GameManager.Instance.IsPaused = true;
        PauseUI.SetActive(true);
        Cursor.visible = true;
        Time.timeScale = 0f;
    }
}
