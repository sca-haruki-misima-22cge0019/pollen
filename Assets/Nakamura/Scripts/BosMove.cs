
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BosMove : MonoBehaviour
{
    private float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position -= new Vector3(Time.deltaTime * speed, 0.0f);
        if (this.gameObject.transform.position.x < 6.0f)
        {
            speed = 0.0f;
        }
    }
}
