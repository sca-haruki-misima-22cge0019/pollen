using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreC: MonoBehaviour
{

    public GameObject score_object = null; // Text�I�u�W�F�N�g
    public int score = 0; // �X�R�A�ϐ�

    // ������
    void Start() {
        score = PlayerPrefs.GetInt("SCORE", 0);
    }

    // �X�V
    void Update() {
        // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = score_object.GetComponent<Text>();
        // �e�L�X�g�̕\�������ւ���
        score_text.text = "Score:" + score;
        
    }
}