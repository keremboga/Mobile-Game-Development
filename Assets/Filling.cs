using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Filling : MonoBehaviour
{
    public Slider slider;
    public int fillSpeed;   //  filling speed
    public int scoreValue;  //  score
    public static int counter;
    public Stars starObject; 
    public void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    public void setScore(int score)
	{
        scoreValue = score; 
	}
    public void setFillSpeed(int speed)
	{
        fillSpeed = speed; 
	}
    void Start()
	{
        slider.maxValue = 2500;
        slider.value = 0;
        counter = 0;
        setScore(1999);  //you can optimize score
        setFillSpeed(1); // you can optimize the filling speed of the score bar
        if(scoreValue > slider.maxValue)
		{
            setScore((int)slider.maxValue);
		} 
        
	}
  
    
   

    
    void Update()
    {
        if(counter < scoreValue)
		{
            counter += fillSpeed; 
        }
        if(counter > scoreValue)
		{
            counter = scoreValue;  
                 
		}
        print(counter);
        slider.value = counter;
        starObject.starScore((int)slider.value); 
        
		
        
    }
}
