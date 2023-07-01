using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    //public int energy = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("AAA");
        if (transform.position.x >= 45.0f)
        {
            //Debug.Log("aaa");
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collider) 
    {
        Debug.Log("tttt");
        if(collider.gameObject.CompareTag("Enemy")) {
            //if(energy <= 0) {
                Debug.Log("AAA");
                Destroy(gameObject);
            //}
        }
        if (collider.gameObject.CompareTag("Mask"))
        {
            //if(energy <= 0) {
            Debug.Log("BBB");
            Destroy(gameObject);
            //}
        }
        if (collider.gameObject.CompareTag("SuperDrugMove"))
        {
            //if(energy <= 0) {
            Debug.Log("CCC");
            Destroy(gameObject);
            //}
        }
    }
}
