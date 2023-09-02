using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflection : MonoBehaviour
{

    Vector2 lastVelocity = Vector2.zero;
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("“–‚½‚Á‚½");
        if(collision.gameObject.tag == "Border")
        {
            Debug.Log("”½ŽË");
            Vector2 normalVector = collision.contacts[0].normal;

            Vector2 refrectVector = Vector2.Reflect(lastVelocity, normalVector);

            rb2d.velocity = refrectVector;
        }
    }

}
