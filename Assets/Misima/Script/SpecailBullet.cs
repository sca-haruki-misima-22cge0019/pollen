using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecailBullet : MonoBehaviour
{
    //スペシャル弾のプレハブ
    public GameObject SpecailBulletPrefab;
    //生成時間の間隔
    private float interval;
    //経過時間
    private float time = 0f;
     // Start is called before the first frame update
    void Start()
     {
        //時間間隔の決定
        interval = 15f;
    }
    // Update is called once per frame
    void Update()
    {
        //時間計測
        time += Time.deltaTime;
        //経過時間が生成時間になったとき
        if(time > interval)
        {
            //スペシャル弾をインスタンス化
            GameObject SpecailBullet = Instantiate(SpecailBulletPrefab);
            //生成した敵の座標を決定する
            SpecailBullet.transform.position = new Vector3(0,10,0);
            //経過時間を初期化して再度経過時間を始める
            time = 0f;

        }
    }
}