using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectionShot : MonoBehaviour
{
    int count= 0;
    GameObject Nose;
    hit hp;
    // Start is called before the first frame update
    void Start()
    {
        Nose = GameObject.Find("Nose");
        hp = Nose.GetComponent<hit>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(count);
        if(count >=2 || hp.energy <=0)
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
