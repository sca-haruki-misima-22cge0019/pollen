using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarrierPoint : MonoBehaviour
{
    public List<GameObject> nowList = new List<GameObject>();
    public List<GameObject> oriList = new List<GameObject>();
    public List<GameObject> Bar = new List<GameObject>();

    private int rnd;
    private  int hp;
    private int maxhp = 8;
    private float nowhp;
    int count = 40;
    [SerializeField] GameObject Barrier;
    [SerializeField] GameObject BosHp;
    [SerializeField] GameObject BarrierBar;
    private Animator BarrierFlashanim;
    private Animator Baranim;
    // Start is called before the first frame update
    void Start()
    {
        
        BarrierFlashanim = Barrier.GetComponent<Animator>();
        Baranim = BarrierBar.GetComponent<Animator>();
        Invoke("firstpoint",4.0f);
        hp = maxhp;
        BosHp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            PointDamage.Damage = true;
            Debug.Log("LL");
            hp = 0;
        }
        //Debug.Log(i);
        if (PointDamage.Damage)
        {
            HpDown();
            BarrierFlashanim.SetBool("BarrierBL",true);

            nowList[rnd].gameObject.SetActive(false);
            nowList.RemoveAt(rnd);
            Invoke("Flash",1.0f);
            PointDamage.Damage = false;   
        }
        
    }
    void firstpoint()
    {
        Baranim.SetBool("BarBL", true);
        rnd = Random.Range(0, hp);
        nowList[rnd].gameObject.SetActive(true);
    }
    void Flash()
    {
        if (hp <= 0)
        {
            Baranim.SetBool("BarDownBL", true);
            nowList.AddRange(oriList);
            Invoke("Down", 1.0f);
        }
        else
        {
            rnd = Random.Range(0, hp);
            nowList[rnd].gameObject.SetActive(true);

            BarrierFlashanim.SetBool("BarrierBL", false);
        }

    }

    void HpDown()
    {
        hp--;
        StartCoroutine(BarrierDecline(0.1f));
    }
    IEnumerator BarrierDecline(float second)
    {
        while (true)
        {
            yield return new WaitForSeconds(second);
            count--;
            Image barimage = Bar[count].GetComponent<Image>();
            barimage.color = new Color(0, 0, 0, 255);
            Debug.Log("Loop");
            if(count%5 == 0)
            {
                break;
            }
        }
    }

    void Down()
    {
        Baranim.SetBool("BarBL", false);
        Baranim.SetBool("BarDownBL", false);
        Barrier.SetActive(false);
        BosHp.SetActive(true);
        hp = maxhp;
        count = 40;
        PointDamage.Damage = false;

        rnd = Random.Range(0, hp);
        nowList[rnd].gameObject.SetActive(true);

        BarrierFlashanim.SetBool("BarrierBL", false);
    }
}
