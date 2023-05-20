
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCre : MonoBehaviour
{
    [SerializeField] GameObject item;
    float X;
    float Y;
    float Itemcount = 5.0f;
    float time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(Itemcount <= time)
        {
            X = Random.Range(9.6f, 14.0f);
            Y = Random.Range(-4.5f, 4.5f);
            Instantiate(item, new Vector3(X, Y), Quaternion.identity);
            time = 0.0f;
        }
        
    }
}
