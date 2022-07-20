using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreCounter : MonoBehaviour
{
    public Text scoreText;
    
    void Start()
    {
        scoreText.text = "Score =" + 0; 
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score =" + Filling.counter; 
    }
}
