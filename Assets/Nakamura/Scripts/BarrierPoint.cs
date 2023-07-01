using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarrierPoint : MonoBehaviour
{
    public List<GameObject> nowList = new List<GameObject>();
    public List<GameObject> oriList = new List<GameObject>();

    private int rnd;
    private  int hp;
    private int maxhp = 8;
    private float nowhp;
    [SerializeField] Slider slider;
    [SerializeField] GameObject Barrier;
    [SerializeField] CanvasGroup BarrierBar;
    [SerializeField] GameObject BosHp;
    private Animator BarrierFlashanim;
    private Animator Baranim;
    // Start is called before the first frame update
    void Start()
    {
        
        BarrierFlashanim = Barrier.GetComponent<Animator>();
        Baranim = slider.GetComponent<Animator>();
        Invoke("firstpoint",4.0f);
        slider.value = 1;
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
            StartCoroutine(DecreaseHPAnimation(maxhp, --hp));

            BarrierFlashanim.SetBool("BarrierBL",true);

            nowList[rnd].gameObject.SetActive(false);
            nowList.RemoveAt(rnd);
            Invoke("Flash",1.0f);
            PointDamage.Damage = false;   
        }
        
    }

    IEnumerator DecreaseHPAnimation(int oldHP, int newHP)
    {
        nowhp = (float)newHP / (float)oldHP;
        Debug.Log(nowhp);
        while (slider.value >= nowhp)
        {
            slider.value -= 0.001f;
            yield return null;
        }

        Debug.Log(slider.value);
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

    void Down()
    {
        Baranim.SetBool("BarBL", false);
        Baranim.SetBool("BarDownBL", false);
        Barrier.SetActive(false);
        BosHp.SetActive(true);
        hp = maxhp;
        slider.value = 1;
        PointDamage.Damage = false;

        rnd = Random.Range(0, hp);
        nowList[rnd].gameObject.SetActive(true);

        BarrierFlashanim.SetBool("BarrierBL", false);
    }
}
