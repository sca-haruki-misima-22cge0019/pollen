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

    public int Numberbullet = 10;

    bool flag = true;

    [Tooltip("�c�e��")]
    [SerializeField] Image Drug;
    [Tooltip("�c�e")]
    [SerializeField] GameObject DrugCount;
    public List<Sprite> DrugList = new List<Sprite>();
    //private int drug = 10;
    private Animator anim;
    [SerializeField] GameObject DrugObject;
    //[SerializeField] float angle; // �p�x
    //Vector3 velocity; // �ړ���
    //bool boost = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = DrugObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Text DrugText = DrugCount.GetComponent<Text>();
        DrugText.text = Numberbullet.ToString();
        if(Time.timeScale == 1)//�|�[�Y��ʂ��f���Ă��Ȃ��Ȃ��
        {
 
            // �X�y�[�X�L�[�������ꂽ���𔻒�
            if (Input.GetKeyDown(KeyCode.Space) && Numberbullet > 0)
            {
                // �e�𔭎˂���
                LauncherShot();
                Drug.sprite = DrugList[Numberbullet];
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
            if (Numberbullet == 0)
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
        //drug = 10;
        anim.SetBool("DrugBL", false);
    }
    /// <summary>
	/// �e�̔���
	/// </summary>
    private void LauncherShot()
    {
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
        Numberbullet -= 1;

    }
}
