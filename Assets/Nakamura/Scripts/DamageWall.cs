using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageWall : MonoBehaviour
{
    private Animator anim;
    [SerializeField] GameObject wall;
    [SerializeField] GameObject nose;
    public bool damage = false;
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
        if (collider.gameObject.tag == "Enemy" && nose.tag == "Untagged")
        {
            damage = true;
            anim.SetBool("DamageBL", true);
            GetComponent<AudioSource>().Play();
            Invoke("RedStop",0.4f);
        }
    }

    void RedStop()
    {
        damage = false;
        anim.SetBool("DamageBL", false);
    }
}
