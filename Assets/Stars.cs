using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class Stars : MonoBehaviour
{
    public GameObject[] emptyStars = new GameObject[3];
    public GameObject[] stars = new GameObject[3]; 
    void Start()
    {
        for (int i = 0;  i < stars.Length; i++){
            emptyStars[i].SetActive(true);
            stars[i].SetActive(false); 
		}
    }

    public void starScore(int score)
	{
        if(score>1500 && score <= 1700)
		{
            emptyStars[0].SetActive(false);
            stars[0].SetActive(true); 

		}
        if(score >1700 && score <= 2000)
		{
            emptyStars[1].SetActive(false);
            stars[1].SetActive(true);
        }
        if(score>2000 && score <= 2500)
		{
            emptyStars[2].SetActive(false);
            stars[2].SetActive(true);
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
