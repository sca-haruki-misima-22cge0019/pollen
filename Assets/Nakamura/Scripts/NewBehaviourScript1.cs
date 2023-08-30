using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    Animator animator;
    [SerializeField] float SecondMotionTime;
    float time = 0.0f;
    bool end = false;
    float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        animator.SetBool("Default1BL", true);
    }

    // Update is called once per frame
    void Update()
    {
        if(end)
        {
            transform.position -=new Vector3(0,Time.deltaTime*speed);
        }
        BossHp bosHp = GetComponent<BossHp>();
        if (!bosHp.damage)
        {
            time += Time.deltaTime;
            if (time >= SecondMotionTime)
            {
                animator.SetBool("Default2BL", true);

            }
        }
        

        
        if(bosHp.damage)
        {
            animator.SetBool("DamageBL", true);
            bosHp.damage = false;
        }
        if (bosHp.death)
        {
            animator.SetBool("DeathBL", true);
        }

    }
    public void Default2()
    {
        animator.SetBool("Default2BL", false);
        time = 0.0f;
    }

    public void Damage()
    {
        animator.SetBool("DamageBL", false);
    }

    public void End()
    {
        end = true;
    }

}
