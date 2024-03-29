using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarrierPoint : MonoBehaviour
{
    public List<GameObject> Nowtarget = new List<GameObject>();
    public List<GameObject> Alltarget = new List<GameObject>();
    public List<GameObject> Bar = new List<GameObject>();

    private int rnd;
    private int hp;
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
        Bar.RemoveAt(0);
        BarrierFlashanim = Barrier.GetComponent<Animator>();
        Baranim = BarrierBar.GetComponent<Animator>();
        Invoke("firstpoint", 2.0f);
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
            BarrierFlashanim.SetBool("BarrierBL", true);
            GetComponent<AudioSource>().Play();
            Nowtarget[rnd].gameObject.SetActive(false);
            Nowtarget.RemoveAt(rnd);
            Invoke("Flash", 1.0f);
            PointDamage.Damage = false;
        }

    }
    void firstpoint()
    {
        Baranim.SetBool("BarBL", true);
        rnd = Random.Range(0, hp);
        Nowtarget[rnd].gameObject.SetActive(true);
    }
    void Flash()
    {
        if (hp <= 0)
        {
            Baranim.SetBool("BarDownBL", true);
            Nowtarget.AddRange(Alltarget);
            Invoke("Down", 1.0f);
        }
        else
        {
            rnd = Random.Range(0, hp);
            Nowtarget[rnd].gameObject.SetActive(true);

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
        while (count >=0)
        {
            yield return new WaitForSeconds(second);
            count--;
            if(count >=0)
            {
                Image barimage = Bar[count].GetComponent<Image>();
                barimage.color = new Color(0, 0, 0, 255);
                if (count % 5 == 0)
                {
                    break;
                }
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
        for(int count= 0; count<=39;count++)
        {
            Image barimage = Bar[count].GetComponent<Image>();
            barimage.color = new Color(1, 1, 1, 255);
        }
        count= 40;
        PointDamage.Damage = false;

        rnd = Random.Range(0, hp);
        Nowtarget[rnd].gameObject.SetActive(true);

        BarrierFlashanim.SetBool("BarrierBL", false);
    }
}
