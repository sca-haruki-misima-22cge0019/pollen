using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x <=-9.4f  || this.transform.position.x >= 16.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
