using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI Timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TimerUpdate(float tiemeRemaining)
    {
        Timer.text = "Tiempo: " + tiemeRemaining.ToString("F0");
    }
}
