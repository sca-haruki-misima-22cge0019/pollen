using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    Animator animator;
    [SerializeField] float SecondMotionTime;
    float time = 0.0f;
    float movetime = 2.4f;
    float damagetime = 2.2f;
    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        animator.SetBool("Default1BL", true);
    }

    // Update is called once per frame
    void Update()
    {
        BossHp bosHp = GetComponent<BossHp>();
        Debug.Log(bosHp.damage);
        
        Damage();
        //Move();
       
    }

    /*void Move()
    {
        if (time >= SecondMotionTime)
        {
            animator.SetBool("Default2BL", true);
            if (time >= SecondMotionTime + movetime)
            {
                animator.SetBool("Default2BL", false);
                time = 0.0f;
            }
        }
    }*/

    void Damage()
    {
        BossHp bosHp = GetComponent<BossHp>();
        if (bosHp.damage)
        {
            animator.SetBool("DamageBL", true);
            time += Time.deltaTime;
            if (time >= damagetime)
            {
                animator.SetBool("DamageBL", false);
                bosHp.damage = false;
                time = 0.0f;
            }
            
        }
        
    }
}
