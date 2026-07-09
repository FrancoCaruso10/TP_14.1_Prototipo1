using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public int winScore = 3;
    float timer = 60f;
    bool gameEnded = false;

    public TextMeshProUGUI scoreText;
    public UIManager uiManager;

    void Start()
    {
        Time.timeScale = 1;
        UpdateScore(0);
    }

    void Update()
    {
        if (!gameEnded)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                uiManager.TimerUpdate(timer);
            }
            else
            {
                timer = 0;
                GameOver();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    public void UpdateScore(int points)
    {
        score += points; 
        scoreText.text = "Score: " + score;

        if (!gameEnded && score >= winScore)
        {
            Win();
        }
    }

    void Win()
    {
        gameEnded = true;
        Time.timeScale = 0;
        uiManager.MostrarPantallaWin();
    }

    void GameOver()
    {
        gameEnded = true;
        Time.timeScale = 0;
        uiManager.MostrarPantallaGameOver();
    }
}
