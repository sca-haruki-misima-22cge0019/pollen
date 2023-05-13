using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 3;
    public enum ENEMY_TYPE
    {
        LINE,//まっすぐ進む
        CURVE//上下にカーブ
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
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        // 上下にカーブ
        if (type == ENEMY_TYPE.CURVE)
        {
            if (cycleCount > 0)
            {
                cycleRadian += (cycleCount * 2 * Mathf.PI) / 50;
                pos.y = Mathf.Sin(cycleRadian) * curveLength + centerY;
            }
        }
        pos += -transform.right * speed * Time.fixedDeltaTime;

        transform.position = pos;
    }
}
