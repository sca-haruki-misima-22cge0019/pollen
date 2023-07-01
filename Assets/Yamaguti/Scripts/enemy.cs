using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private GameObject target;
    public float speed = 1;
    public enum ENEMY_TYPE
    {
        LINE,//まっすぐ進む
        CURVE,//上下にカーブ
        TRACKING
    }
    public ENEMY_TYPE type = ENEMY_TYPE.CURVE;
    public float cycleCount = 1;    // １秒間に往復する回数
    public float curveLength = 2;   // カーブの最大距離
    float cycleRadian = 0;          // サインに渡す値
    float centerY;                  // Y座標の中心
    // Start is called before the first frame update
    void Start()
    {
        centerY = transform.position.y;
        target = GameObject.Find("Nose");

        //int test1 = LayerMask.NameToLayer("Enemy");
        //Physics.IgnoreLayerCollision(test1, test1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale !=0)
        {
            Vector2 pos = transform.position;
            // 上下にカーブ
            if (type == ENEMY_TYPE.CURVE)
            {
                if (cycleCount > 0)
                {
                    cycleRadian += (cycleCount * 2 * Mathf.PI) / 50;
                    pos.y = Mathf.Sin(cycleRadian) * curveLength + centerY;
                }
            }
            pos += new Vector2(-1 * speed * Time.fixedDeltaTime, 0);

            transform.position = pos;

            if (type == ENEMY_TYPE.TRACKING)
            {
                transform.LookAt(target.transform);
                transform.position += transform.forward * speed;
            }
        }
        
    }
}
