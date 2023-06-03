using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClearC : MonoBehaviour
{
    public GameObject score_object = null;
    public int score_num = 0;
    // Start is called before the first frame update
    void Start()
    {
        score_num = PlayerPrefs.GetInt("SCOER", 0);
    }
    private void OnDestroy() 
    {
        PlayerPrefs.SetInt("SCORE",score_num);
        PlayerPrefs.Save();
        PlayerPrefs.DeleteAll();
        // 引数で指定したキーを削除する
        PlayerPrefs.DeleteKey("K");
    }
    // Update is called once per frame
    void Update()
    {
        Text score_text = score_object.GetComponent<Text>();

        score_text.text = "Score:" + score_num;

        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Stege2");
        }
    }
}
