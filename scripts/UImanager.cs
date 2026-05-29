using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    public scoreManager Score; 
    public TextMeshProUGUI texto;
    
    void Start()
    {
        texto= GetComponent<TextMeshProUGUI>();
    }

    
    void Update()
    {
        if (Score != null && texto != null){
        texto.text = "Score: " + Score.score.ToString();
        }
    }
}
