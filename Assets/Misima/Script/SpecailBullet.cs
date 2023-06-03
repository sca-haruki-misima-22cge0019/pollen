using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecailBullet : MonoBehaviour
{
    //�X�y�V�����e�̃v���n�u
    public GameObject SpecailBulletPrefab;
    //�������Ԃ̊Ԋu
    private float interval;
    //�o�ߎ���
    private float time = 0f;
     // Start is called before the first frame update
    void Start()
     {
        //���ԊԊu�̌���
        interval = 15f;
    }
    // Update is called once per frame
    void Update()
    {
        //���Ԍv��
        time += Time.deltaTime;
        //�o�ߎ��Ԃ��������ԂɂȂ����Ƃ�
        if(time > interval)
        {
            //�X�y�V�����e���C���X�^���X��
            GameObject SpecailBullet = Instantiate(SpecailBulletPrefab);
            //���������G�̍��W�����肷��
            SpecailBullet.transform.position = new Vector3(0,10,0);
            //�o�ߎ��Ԃ����������čēx�o�ߎ��Ԃ��n�߂�
            time = 0f;

        }
    }
}