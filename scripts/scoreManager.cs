using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreManager : MonoBehaviour
{
    public int score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){
        if (col.gameObject.CompareTag("pickable")) {
          Destroy(col.gameObject);
          Debug.Log("Pickable destruido");
          score += 1;
          Debug.Log("Puntaje actual: " + score);
        }
    }
}
