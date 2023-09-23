using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClearCS2 : MonoBehaviour
{
    private float step_time;//経過時間カウント用
    [SerializeField] GameObject Fade;
    // Start is called before the first frame update
    void Start()
    {
        step_time = 0.0f;//経過時間初期化
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Fade.GetComponent<Animator>().enabled = true;
            //SceneManager.LoadScene("Stage2");
        }
        //経過時間をカウント
        step_time += Time.deltaTime;

        //3秒後に画面遷移
        if (step_time >= 3.0f)
        {
            Fade.GetComponent<Animator>().enabled = true;
            //SceneManager.LoadScene("Stage2");
        }

    }

    public void stage()
    {
        SceneManager.LoadScene("Bos");
    }


}