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
        ScoreMaster = GameObject.Find("ScoreData");//�X�R�A�f�[�^��������
        Sd = ScoreMaster.GetComponent<ScoreData>();

        Score = Sd.GetScore();//�X�R�A�f�[�^�̒���GetScore�֐����Ăяo��
        //�A�^�b�`�����I�u�W�F�N�g�ɔ��f�������e�L�X�g��R�t����
        tx.text = string.Format("Score {0}",Score);
    }
}
