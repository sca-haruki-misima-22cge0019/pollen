using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nose : MonoBehaviour
{
    [SerializeField]GameObject damageWall;
    private bool stop;
    private float time ;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = damageWall.GetComponent<Animator>();
        anim.updateMode = AnimatorUpdateMode.UnscaledTime;
        stop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(stop)
        {
            time += Time.unscaledDeltaTime;
            anim.SetBool("DamageBL", true);
            if (time >=1.0f)
            {
                Time.timeScale = 1;
                damageWall.SetActive(false);
                anim.SetBool("DamageBL", false);
                time =0;
                stop = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            damageWall.SetActive(true);
            collision.gameObject.SetActive(false);
            stop=true;
            Time.timeScale = 0;
        }   
    }
}
