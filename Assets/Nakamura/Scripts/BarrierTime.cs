using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarrierTime : MonoBehaviour
{
    private float noTime = 0.0f;
    [SerializeField] GameObject Barrier;
    [SerializeField] GameObject TimeUIObject;
    [SerializeField] GameObject BosHp;
    [SerializeField] GameObject BarrierHp;
    private Animator Baranim;
    private Animator BarrierHpanim;

    // Start is called before the first frame update
    void Start()
    {
        Baranim = BosHp.GetComponent<Animator>();
        BarrierHpanim = BarrierHp.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        BossHp bosHp = GetComponent<BossHp>();
        if(!(bosHp.death))
        {
            TimeUIObject.SetActive(false);
            if (!Barrier.activeSelf)
            {
                noTime += Time.deltaTime;
                Baranim.SetBool("BarBL", true);

                if (noTime >= 7.0f)
                {
                    TimeUIObject.SetActive(true);
                    int count = (int)noTime;
                    count = 10 - count;
                    Text TimeText = TimeUIObject.GetComponent<Text>();
                    TimeText.text = count.ToString();
                }
            }
            else
            {
                Baranim.SetBool("BarBL", false);
            }

            if (noTime >= 10.0f)
            {
                Baranim.SetBool("BarDownBL", true);
                Invoke("Down", 1.0f);
                noTime = 0.0f;
                Barrier.SetActive(true);
                TimeUIObject.SetActive(false);
                BarrierHpanim.SetBool("BarBL", true);
            }
        }
        else
        {
            //gameObject.SetActive(false);
        }
        
    }

    void Down()
    {
        Baranim.SetBool("BarDownBL", false);
    }
}
