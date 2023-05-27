using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCount : MonoBehaviour
{
    [SerializeField] GameObject ScoreObject;
    private int score = 0;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(score.Length)
        Text ScoreText = ScoreObject.GetComponent<Text>();

        if(Input.GetKey(KeyCode.L))
        {
            score++;
            if (score > 999999)
            {
                score = 999999;
            }
        }
        if(score<=9)
        {

            ScoreText.text = "Score:00000" + score;
        }
        else if (score <= 99)
        {

            ScoreText.text = "Score:0000" + score;
        }
        else if (score <= 999)
        {

            ScoreText.text = "Score:000" + score;
        }
        else if (score <= 9999)
        {

            ScoreText.text = "Score:00" + score;
        }
        else if (score <= 99999)
        {

            ScoreText.text = "Score:0" + score;
        }
        else
        {

            ScoreText.text = "Score:" + score;
        }

        
    }
}
