using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClearC : MonoBehaviour
{
    private float step_time;//�o�ߎ��ԃJ�E���g�p

    // Start is called before the first frame update
    void Start() 
    {
        step_time = 0.0f;//�o�ߎ��ԏ�����
    }

    // Update is called once per frame
    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Return)) {
            SceneManager.LoadScene("Stage2");
        }
        //�o�ߎ��Ԃ��J�E���g
        step_time += Time.deltaTime;

        //3�b��ɉ�ʑJ��
        if(step_time >= 3.0f) 
        {
            SceneManager.LoadScene("Stage2");
        }

    }

}

