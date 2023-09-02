using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectionShot : MonoBehaviour
{
    int count= 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(count);
        if(count >=3)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Border")
        {
            count++;
        }
    }
}
