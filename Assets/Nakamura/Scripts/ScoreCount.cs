using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCount : MonoBehaviour
{
    [SerializeField] GameObject ScoreObject;
    public static int score = 0;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(score.Length)
        Text ScoreText = ScoreObject.GetComponent<Text>();
        if(score<=9)
        {

            ScoreText.text = "SCORE�F00000" + score;
        }
        else if (score <= 99)
        {

            ScoreText.text = "SCORE�F0000" + score;
        }
        else if (score <= 999)
        {

            ScoreText.text = "SCORE�F000" + score;
        }
        else if (score <= 9999)
        {

            ScoreText.text = "SCORE�F00" + score;
        }
        else if (score <= 99999)
        {

            ScoreText.text = "SCORE�F0" + score;
        }
        else
        {

            ScoreText.text = "SCORE�F" + score;
        }

        
    }
}
