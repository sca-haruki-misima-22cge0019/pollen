using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreC: MonoBehaviour
{

    public GameObject score_object = null; // Textオブジェクト
    public int score = 0; // スコア変数

    // 初期化
    void Start() {
        score = PlayerPrefs.GetInt("SCORE", 0);
    }

    // 更新
    void Update() {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "Score:" + score;
        
    }
}