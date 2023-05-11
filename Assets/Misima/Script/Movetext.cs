using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movetext : MonoBehaviour
{
    private Vector3 textpos;
    // Start is called before the first frame update
    void Start()
    {
        textpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 10.0f + textpos.x,textpos.y,textpos.z);
    }
}
