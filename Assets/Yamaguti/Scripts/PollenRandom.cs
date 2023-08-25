
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PollenRandom : MonoBehaviour
{
    [SerializeField] List<GameObject> enemyList;    // �����I�u�W�F�N�g
    [SerializeField] Transform pos;                 // �����ʒu
    [SerializeField] Transform pos2;                // �����ʒu
    float minX, maxX, minY, maxY;                   // �����͈�

    int frame = 0;
    [SerializeField] int generateFrame = 30;        // ��������Ԋu

    GameObject bos;

    // Start is called before the first frame update
    void Start()
    {
        minX = Mathf.Min(pos.position.x, pos2.position.x);
        maxX = Mathf.Max(pos.position.x, pos2.position.x);
        minY = Mathf.Min(pos.position.y, pos2.position.y);
        maxY = Mathf.Max(pos.position.y, pos2.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale != 0)
        {
            bos = GameObject.Find("Boss");
            BossHp bosHp = bos.GetComponent<BossHp>();
            if(!(bosHp.death))
            {
                ++frame;

                if (frame > generateFrame)
                {
                    frame = 0;

                    // �����_���Ŏ�ނƈʒu�����߂�
                    int index = Random.Range(0, enemyList.Count);
                    float posX = Random.Range(minX, maxX);
                    float posY = Random.Range(minY, maxY);

                    Instantiate(enemyList[index], new Vector3(posX, posY, 0), Quaternion.identity);
                }
            }
            
        }
       
    }
}
