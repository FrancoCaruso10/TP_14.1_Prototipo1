using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI Timer;

    public GameObject winPanel ;
    public GameObject gameOverPanel ;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    public void TimerUpdate(float tiemeRemaining)
    {
        Timer.text = "Tiempo: " + tiemeRemaining.ToString("F0");
    }

    public void MostrarPantallaWin()
    {
        winPanel.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        gameOverPanel.SetActive(true);
    }
}
