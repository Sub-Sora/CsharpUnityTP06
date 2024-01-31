using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreUI : MonoBehaviour
{

    public TextMeshProUGUI ScoreText;

    private void Start()
    {
        UpdateScore(GameManager.Instance.Score);
    }

    /// <summary>
    /// Va mettre à jours le score du joueur
    /// </summary>
    /// <param name="score">Variable int du score du joueur</param>
    public void UpdateScore(int score)
    {
        if (ScoreText != null)
        {
            ScoreText.text = "Score: " + score.ToString();
        }
    }
}
