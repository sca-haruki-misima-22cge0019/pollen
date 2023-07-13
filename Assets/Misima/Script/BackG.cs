using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackG : MonoBehaviour
{
    //バックグラウンドを動かす

    [SerializeField]
    float scrollSpeed = -1;

    Vector2 cameraRecrMin;

    // Start is called before the first frame update
    void Start()
    {
        //カメラ範囲の取得
        cameraRecrMin = Camera.main.ViewportToWorldPoint(new Vector2(Camera.main.transform.position.x,0));
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.Translate(Vector2.right * scrollSpeed * Time.deltaTime);//x軸方向にスクロール
        //カメラの左端が完全に出たら、右端に瞬間移動
        if (transform.position.x < (cameraRecrMin.x - Camera.main.transform.position.x) * 2)
        {
            transform.position = new Vector2((Camera.main.transform.position.x - cameraRecrMin.x)*2,
                transform.position.y);
        }
    }
}
