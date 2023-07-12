using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageWall : MonoBehaviour
{
    private Animator anim;
    [SerializeField] GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        anim = wall.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Enemy")
        {
            anim.SetBool("DamageBL", true);
            Invoke("RedStop",0.4f);
        }
    }

    void RedStop()
    {
        anim.SetBool("DamageBL", false);
    }
}
