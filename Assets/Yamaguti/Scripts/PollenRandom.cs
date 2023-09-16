using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PollenRandom : MonoBehaviour
{
    [SerializeField] List<GameObject> enemyList;    // 生成オブジェクト
    [SerializeField] Transform pos;                 // 生成位置
    [SerializeField] Transform pos2;                // 生成位置
    float minX, maxX, minY, maxY;                   // 生成範囲

    float frame = 0;
    [SerializeField] float generateFrame;        // 生成する間隔

    GameObject bos;
    GameObject fade;
    FadeIn fadein;
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
            if (SceneManager.GetActiveScene().name == "Bos")
            {
                bos = GameObject.Find("Boss");
                BossHp bosHp = bos.GetComponent<BossHp>();
                if (!(bosHp.death))
                {
                   Cre();
                }
            }
            else
            {
                Cre();
            }
           
            
        }
    }

    void Cre()
    {
        frame+= Time.deltaTime;

        if (frame > generateFrame)
        {
            frame = 0.0f;

            // ランダムで種類と位置を決める
            int index = Random.Range(0, enemyList.Count);
            float posX = Random.Range(minX, maxX);
            float posY = Random.Range(minY, maxY);

            Instantiate(enemyList[index], new Vector3(posX, posY, 0), Quaternion.identity);
        }
    }
}
