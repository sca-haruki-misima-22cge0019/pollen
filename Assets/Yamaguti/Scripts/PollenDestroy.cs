using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PollenDestroy : MonoBehaviour
{
    GameObject nose;
    hit hp;
    // Start is called before the first frame update
    void Start()
    {
        nose = GameObject.Find("Nose");
        hp = nose.GetComponent<hit>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10 || hp.energy <=0)
        {
            Debug.Log("sinderu");
            Destroy(gameObject);
        }
    }
}
