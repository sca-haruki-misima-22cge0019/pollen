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
    //private int Currenthp;
    [SerializeField] Slider slider;
    [SerializeField] GameObject Barrier;
    [SerializeField] GameObject BarrierHP;
    [SerializeField] GameObject BosHp;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = Barrier.GetComponent<Animator>();
        Invoke("firstpoint",3.0f);
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

            anim.SetBool("BarrierBL",true);

            nowList[rnd].gameObject.SetActive(false);
            nowList.RemoveAt(rnd);
            Invoke("Flash",1.0f);

           
            PointDamage.Damage = false;
            
        }
        
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
        }

        rnd = Random.Range(0, hp);
        nowList[rnd].gameObject.SetActive(true);

        anim.SetBool("BarrierBL", false);
    }
}
