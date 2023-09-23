using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FireBullet : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�e�̔��ˏꏊ")]
    private GameObject firingPoint;

    [SerializeField]
    [Tooltip("�e")]
    private GameObject bullet;

    [SerializeField]
    [Tooltip("����e")]
    private GameObject superdrug;

    [SerializeField]
    [Tooltip("�e�̑���")]
    private float speed = 30f;

    [SerializeField]
    [Tooltip("����e�̑���")]
    private float superdrugspeed = 30f;

    public int Numberbullet;

    public int Numbersuperdrug;

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
    GameObject Bullet;
    [SerializeField] int BoostTime;
    [SerializeField] float  reloadtime = 1.5f;
    public bool reload = false;
    float time;
    float nowtime = 0.0f;
    [SerializeField] private AudioSource Shot;
    [SerializeField] private AudioSource SuperShot;
    [SerializeField] private AudioClip ShotSound;
    [SerializeField] private AudioClip SuperShotSound;
    [SerializeField] GameObject DrugTextCount;
    private DrugCount drugCount;
    GameObject Nose;
    hit hp;

    [SerializeField] float shottime = 10.0f;
    public bool shot = false;
    float nowshottime = 0.0f;
    //[SerializeField] float angle; // �p�x
    //Vector3 velocity; // �ړ���
    //bool boost = false;

    // Start is called before the first frame update
    void Start()
    {
        DrugText = DrugCount.GetComponent<Text>();
        anim = DrugObject.GetComponent<Animator>();
        Numberbullet = 10;
        Numbersuperdrug = 5;
        Nose = GameObject.Find("Nose");
        hp = Nose.GetComponent<hit>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1 )//�|�[�Y��ʂ��f���Ă��Ȃ��Ȃ��
        {
            // �X�y�[�X�L�[�������ꂽ���𔻒�
            if ((Input.GetKeyDown(KeyCode.K)  || Input.GetKeyDown(KeyCode.L)) && hp.energy > 0 && !shot)
            {
                Shot.PlayOneShot(ShotSound);
                if (Numberbullet == 1)
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
                Debug.Log("tama1");
                nowshottime = 0.0f;
                shot = true;

                

                //if (Numberbullet >= 0)
                //{
                //  Numberbullet--;
                //}

            }

            if (shot)
            {
                Debug.Log("tama2");
                nowshottime += Time.deltaTime;
                if (nowshottime >= shottime)
                {
                    Debug.Log("tama3");
                    shot = false;
                }
            }
            //if (Input.GetKeyDown(KeyCode.R))
            //{
            //    anim.SetBool("DrugBL", true);
            //    StartCoroutine(Shotwait());
            //}

            if (Input.GetKeyDown(KeyCode.Space) && SceneManager.GetActiveScene().name == "Bos" && !reload)
            {
                SuperShot.PlayOneShot(SuperShotSound);
                if (Numbersuperdrug > 0)
                {
                    SuperdrugShot();
                }
                nowtime = 0.0f;
                reload = true;
            }

            if(reload)
            {
                nowtime += Time.deltaTime;
                if (nowtime >= reloadtime)
                {
                    Debug.Log("tama4");
                    reload = false;
                }
            }


            //�e�U�e���擾���Ă���BoostTime�ȏ�o�߂����Ȃ猳�ɖ߂�
            if (this.gameObject.CompareTag("Diffusion"))
            {
                time += Time.deltaTime;
                if (time >= BoostTime)
                {
                    this.gameObject.tag = "Untagged";
                    time = 0.0f;
                }
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

        yield return new WaitForSeconds(0.5f);//0.3�b�҂��Ă���e10����[
        Numberbullet = 10;
        DrugText.text = Numberbullet.ToString();
        Drug.sprite = DrugList[Numberbullet];
        Debug.Log(Numberbullet);
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
        Bullet = newBall;
        BulletMove();
        //�����g�U�e���擾���Ă���̂Ȃ�Q��"bullet"��Prefab���o��������
        if (this.gameObject.CompareTag("Diffusion"))
        {
            GameObject newBall2 = Instantiate(bullet, bulletPosition, transform.rotation * Quaternion.Euler(0, 0, 15));
            Bullet = newBall2;
            BulletMove();
            GameObject newBall3 = Instantiate(bullet, bulletPosition, transform.rotation * Quaternion.Euler(0, 0, -15));
            Bullet = newBall3;
            BulletMove();
        }

    }

    void BulletMove()
    {

        // �o���������{�[����right(x������)
        Vector2 direction = Bullet.transform.right;
        // �e�̔��˕�����newBall��x����(���[�J�����W)�����A�e�I�u�W�F�N�g��rigidbody�ɏՌ��͂�������
        Bullet.GetComponent<Rigidbody2D>().AddForce(direction * speed, ForceMode2D.Impulse);
        // �o���������{�[���̖��O��"bullet"�ɕύX
        Bullet.name = bullet.name;
        // �o���������{�[����0.8�b��ɏ���
        //Destroy(newBall, 0.8f);
    }

    private void SuperdrugShot()
    {
        drugCount = DrugTextCount.GetComponent<DrugCount>();
        drugCount.drug--;
        Numbersuperdrug -= 1;
        // �e�𔭎˂���ꏊ���擾
        Vector2 bulletPosition = firingPoint.transform.position;
        // ��Ŏ擾�����ꏊ�ɁA"bullet"��Prefab���o��������
        GameObject newBall = Instantiate(superdrug, bulletPosition, transform.rotation);
        // �o���������{�[����right(x������)
        Vector2 direction = newBall.transform.right;
        // �e�̔��˕�����newBall��x����(���[�J�����W)�����A�e�I�u�W�F�N�g��rigidbody�ɏՌ��͂�������
        newBall.GetComponent<Rigidbody2D>().AddForce(direction * superdrugspeed, ForceMode2D.Impulse);
        // �o���������{�[���̖��O��"bullet"�ɕύX
        newBall.name = superdrug.name;
        // �o���������{�[����0.8�b��ɏ���
        //Destroy(newBall, 0.8f);
    }
}
