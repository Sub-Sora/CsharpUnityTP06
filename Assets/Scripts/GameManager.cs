using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Score;
    public ScoreUI ScoreUI;
    public bool IsPaused;

    //Singleton
    private static GameManager _instance = null;
    private GameManager() { }
    public static GameManager Instance => _instance;
    //

    private void Awake()
    {
        //Singleton
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            _instance = this;
        }
        //
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        ScoreUI = GameObject.Find("Canvas").GetComponent<ScoreUI>();
    }

    public void AddScore()
    {
        Score++;
        ScoreUI.UpdateScore(Score);
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
