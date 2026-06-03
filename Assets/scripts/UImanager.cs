using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI Timer;

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
}
