using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Time.deltaTime * speed, 0.0f);
    }

    internal void Init(int v1, int v2)
    {
        throw new NotImplementedException();
    }
}

