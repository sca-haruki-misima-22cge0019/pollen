using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public int energy = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= 45)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collider) 
    {
        if(collider.gameObject.tag == "Enemy") {
            //if(energy <= 0) {
                //Debug.Log("AAA");
                Destroy(gameObject);
            //}
        }
    }
}
