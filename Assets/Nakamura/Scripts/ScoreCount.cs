using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    [SerializeField] GameObject ScoreObject;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text ScoreText = ScoreObject.GetComponent<Text>();
        ScoreText.text = "Score:" + score;
    }
}
