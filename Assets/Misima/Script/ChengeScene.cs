using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChengeScene : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))//���N���b�N������
        {
            SceneManager.LoadScene("TestScene");//�e�X�g�V�[���Ɉړ�
        }
    }
}
