using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoseDamage : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Nose.enbl)
        {
            anim.SetBool("DamageBl", false);
        }
        else
        {
            anim.SetBool("DamageBl", true);
        }
    }

}