
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCre : MonoBehaviour
{
    public List<GameObject> Itemselect = new List<GameObject>();
    float X;
    float Y;
    float Itemcount = 5.0f;
    float time = 0.0f;
    int rnd;
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
            rnd = Random.Range(0,3);
            X = Random.Range(9.6f, 14.0f);
            Y = Random.Range(-2.71f,3.42f);
            Instantiate(Itemselect[rnd], new Vector3(X, Y), Quaternion.identity);
            time = 0.0f;
        }
        
    }
}
