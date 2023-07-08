using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBullet : MonoBehaviour
{
    [SerializeField]
    [Tooltip("弾の発射場所")]
    private GameObject firingPoint;

    [SerializeField]
    [Tooltip("弾")]
    private GameObject bullet;

    [SerializeField]
    [Tooltip("弾の速さ")]
    private float speed = 30f;

    public int Numberbullet = 10;

    bool flag = true;

    [Tooltip("残弾数")]
    [SerializeField] Image Drug;
    [Tooltip("残弾")]
    [SerializeField] GameObject DrugCount;
    public List<Sprite> DrugList = new List<Sprite>();
    private int drug = 10;

    //[SerializeField] float angle; // 角度
    //Vector3 velocity; // 移動量
    //bool boost = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Text DrugText = DrugCount.GetComponent<Text>();
        DrugText.text = drug.ToString();
        // スペースキーが押されたかを判定
        if (Input.GetKeyDown(KeyCode.Space)&&Numberbullet>0)
        {
            // 弾を発射する
            LauncherShot();
            if (drug >= 0)
            {
                drug--;
            }
        }
        if (Input.GetKeyDown(KeyCode.R)&&Numberbullet==0)
        {
            StartCoroutine(Shotwait());
            drug = 10;
        }

        Drug.sprite = DrugList[drug];

        /*if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0, 0, 0.2f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, 0, -0.2f);
        }*/
    }

    IEnumerator Shotwait()
    {
        yield return new WaitForSeconds(0.7f);//0.3秒待ってから弾10発補充
        Numberbullet = 10;
    }
    /// <summary>
	/// 弾の発射
	/// </summary>
    private void LauncherShot()
    {
        // 弾を発射する場所を取得
        Vector2 bulletPosition = firingPoint.transform.position;
        // 上で取得した場所に、"bullet"のPrefabを出現させる
        GameObject newBall = Instantiate(bullet, bulletPosition, transform.rotation);
        // 出現させたボールのright(x軸方向)
        Vector2 direction = newBall.transform.right;
        // 弾の発射方向にnewBallのx方向(ローカル座標)を入れ、弾オブジェクトのrigidbodyに衝撃力を加える
        newBall.GetComponent<Rigidbody2D>().AddForce(direction * speed, ForceMode2D.Impulse);
        // 出現させたボールの名前を"bullet"に変更
        newBall.name = bullet.name;
        // 出現させたボールを0.8秒後に消す
        //Destroy(newBall, 0.8f);
        Numberbullet -= 1;
    }
}
