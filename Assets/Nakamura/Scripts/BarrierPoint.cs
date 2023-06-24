using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarrierPoint : MonoBehaviour
{
    public List<GameObject> nowList = new List<GameObject>();
    public List<GameObject> oriList = new List<GameObject>();

    private int rnd;
    private int hp;
    private int maxhp = 8;
    //private bool bar;
   // private float fadetime = 0.3f; 
    [SerializeField] Slider slider;
    [SerializeField] GameObject Barrier;
    [SerializeField] CanvasGroup BarrierBar;
    [SerializeField] GameObject BosHp;
    private Animator BarrierFlashanim;
    // Start is called before the first frame update
    void Start()
    {
        
        BarrierFlashanim = Barrier.GetComponent<Animator>();
        Invoke("firstpoint",4.0f);
        slider.value = 1;
        hp = maxhp;
        BosHp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(i);
        if (PointDamage.Damage)
        {
            hp--;
            slider.value = (float)hp / (float)maxhp;

            BarrierFlashanim.SetBool("BarrierBL",true);

            nowList[rnd].gameObject.SetActive(false);
            nowList.RemoveAt(rnd);
            Invoke("Flash",1.0f);
            PointDamage.Damage = false;   
        }
        /*if(bar)
        {
            Invoke("fade",1.0f);
            
            Debug.Log(BarrierBar.alpha);
            if(BarrierBar.alpha <= 0.0f)
            {
                bar = false;
            }
        }*/
        
    }

    void fade()
    {
        BarrierBar.alpha -= 0.01f;
    }
    void firstpoint()
    {
        rnd = Random.Range(0, hp);
        nowList[rnd].gameObject.SetActive(true);
    }
    void Flash()
    {
        if (hp <= 0)
        {
            Barrier.SetActive(false);
            BosHp.SetActive(true);
            nowList.AddRange(oriList);
            hp = maxhp;
            slider.value = 1;
            PointDamage.Damage = false;


            /*bar = true;
            if(!bar)
            {
                Barrier.SetActive(false);
                BosHp.SetActive(true);
                nowList.AddRange(oriList);
                hp = maxhp;
                slider.value = 1;
                PointDamage.Damage = false;


                rnd = Random.Range(0, hp);
                nowList[rnd].gameObject.SetActive(true);
                BarrierFlashanim.SetBool("BarrierBL", false);
            }*/

        }
        /*else
        {
            rnd = Random.Range(0, hp);
            nowList[rnd].gameObject.SetActive(true);

            BarrierFlashanim.SetBool("BarrierBL", false);
        }*/
        rnd = Random.Range(0, hp);
        nowList[rnd].gameObject.SetActive(true);

        BarrierFlashanim.SetBool("BarrierBL", false);

    }
}
