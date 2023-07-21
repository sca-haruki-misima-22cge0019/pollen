using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBullet : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�e�̔��ˏꏊ")]
    private GameObject firingPoint;

    [SerializeField]
    [Tooltip("�e")]
    private GameObject bullet;

    [SerializeField]
    [Tooltip("�e�̑���")]
    private float speed = 30f;

    public int Numberbullet;

    bool flag = true;

    [Tooltip("�c�e��")]
    [SerializeField] Image Drug;
    [Tooltip("�c�e")]
    [SerializeField] GameObject DrugCount;
    public List<Sprite> DrugList = new List<Sprite>();
    //private int drug = 10;
    private Animator anim;
    [SerializeField] GameObject DrugObject;
    private Text DrugText;
    //[SerializeField] float angle; // �p�x
    //Vector3 velocity; // �ړ���
    //bool boost = false;

    // Start is called before the first frame update
    void Start()
    {
        DrugText = DrugCount.GetComponent<Text>();
        anim = DrugObject.GetComponent<Animator>();
        Numberbullet = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Numberbullet);
        if (Time.timeScale == 1)//�|�[�Y��ʂ��f���Ă��Ȃ��Ȃ��
        {


            // �X�y�[�X�L�[�������ꂽ���𔻒�
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if(Numberbullet == 1)
                {
                    LauncherShot();
                    anim.SetBool("DrugBL", true);
                    StartCoroutine(Shotwait());
 
                }
                if(Numberbullet > 0)
                {
                    // �e�𔭎˂���
                    LauncherShot();
                }
               

                //if (Numberbullet >= 0)
                //{
                //  Numberbullet--;
                //}
                
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                anim.SetBool("DrugBL", true);
                StartCoroutine(Shotwait());
            }


        }
        

        

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

        yield return new WaitForSeconds(0.7f);//0.3�b�҂��Ă���e10����[
        Numberbullet = 10;
        DrugText.text = Numberbullet.ToString();
        Drug.sprite = DrugList[Numberbullet];
        //drug = 10;
        anim.SetBool("DrugBL", false);
    }
    /// <summary>
	/// �e�̔���
	/// </summary>
    private void LauncherShot()
    {
        Numberbullet -= 1;
        DrugText.text = Numberbullet.ToString();
        Debug.Log(Numberbullet);
        Drug.sprite = DrugList[Numberbullet];
        // �e�𔭎˂���ꏊ���擾
        Vector2 bulletPosition = firingPoint.transform.position;
        // ��Ŏ擾�����ꏊ�ɁA"bullet"��Prefab���o��������
        GameObject newBall = Instantiate(bullet, bulletPosition, transform.rotation);
        // �o���������{�[����right(x������)
        Vector2 direction = newBall.transform.right;
        // �e�̔��˕�����newBall��x����(���[�J�����W)�����A�e�I�u�W�F�N�g��rigidbody�ɏՌ��͂�������
        newBall.GetComponent<Rigidbody2D>().AddForce(direction * speed, ForceMode2D.Impulse);
        // �o���������{�[���̖��O��"bullet"�ɕύX
        newBall.name = bullet.name;
        // �o���������{�[����0.8�b��ɏ���
        //Destroy(newBall, 0.8f);

    }
}
