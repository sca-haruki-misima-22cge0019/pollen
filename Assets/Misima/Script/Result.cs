using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    private GameObject ScoreMaster;
    private ScoreData Sd;
    public Text tx;
    int Score;

    // Start is called before the first frame update
    void Start()
    {
        ScoreMaster = GameObject.Find("ScoreData");//スコアデータを見つける
        Sd = ScoreMaster.GetComponent<ScoreData>();

        Score = Sd.GetScore();//スコアデータの中のGetScore関数を呼び出す
        //アタッチしたオブジェクトに反映したいテキストを紐付ける
        tx.text = string.Format("Score {0}",Score);
    }
}
