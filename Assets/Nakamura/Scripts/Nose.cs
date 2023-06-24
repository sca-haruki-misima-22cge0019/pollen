using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nose : MonoBehaviour
{
    [SerializeField]GameObject damageWall;
    [SerializeField] GameObject Pose;
    private bool stop;
    private float time ;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = damageWall.GetComponent<Animator>();
        stop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (stop && Pose.activeSelf == false)
        {
            anim.updateMode = AnimatorUpdateMode.UnscaledTime;
            time += Time.unscaledDeltaTime;
            
            anim.SetBool("DamageBL", true);

            if (time >=1.0f && Pose.activeSelf == false)
            {
                Time.timeScale = 1;
                damageWall.SetActive(false);
                anim.SetBool("DamageBL", false);
                time =0;
                stop = false;
            }
        }

        if (Pose.activeSelf == true)
        {
            anim.speed = 0.0f;

        }
        else
        {
            anim.speed = 1.0f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            damageWall.SetActive(true);
            Destroy(collision.gameObject);
            stop = true;
            Time.timeScale = 0;
        }   
    }
}
