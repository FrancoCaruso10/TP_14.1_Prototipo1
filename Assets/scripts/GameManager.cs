using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score = 0;
    float timer = 60f;
    public TextMeshProUGUI scoreText;
    public UIManager uiManager;

    void Start()
    {
        UpdateScore(0);
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            uiManager.TimerUpdate(timer);
        }
        else
        {
            timer = 0;
        }
    }

    public void UpdateScore(int points)
    {
        score += points; 
        scoreText.text = "Score: " + score; 
    }
}
