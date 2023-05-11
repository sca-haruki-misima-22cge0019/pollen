using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChengeScene : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))//左クリックしたら
        {
            SceneManager.LoadScene("TestScene");//テストシーンに移動
        }
    }
}
