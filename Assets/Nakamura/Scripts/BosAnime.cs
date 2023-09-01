using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BosAnime : MonoBehaviour
{
    Animator animator;
    [SerializeField] float SecondMotionTime;
    float time = 0.0f;
    bool end = false;
    float speed = 5.0f;
    [SerializeField] private AudioSource damage;
    [SerializeField] private AudioSource die;
    [SerializeField] private AudioClip damageSound;
    [SerializeField] private AudioClip dieSound;
    [SerializeField] private AudioSource bgm;
    [SerializeField]GameObject TimeCount;
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
            if(transform.position.y <= -0.2811289f)
            {
                SceneManager.LoadScene("GameClearSceneFinal");
            }
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
            damage.PlayOneShot(damageSound);
            animator.SetBool("DamageBL", true);
            bosHp.damage = false;
        }
        if (bosHp.death)
        {
            TimeCount.SetActive(false);
            die.PlayOneShot(dieSound);
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
