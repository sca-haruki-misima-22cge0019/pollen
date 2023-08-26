using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BosItemCre : MonoBehaviour
{
    public List<GameObject> Itemselect = new List<GameObject>();
    [SerializeField] float itemTime;
    float time = 0.0f;
    int select;
    float X;
    float Y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time+= Time.deltaTime;
        if (itemTime<=time)
        {
            Cre();
            time = 0.0f;
        }
        
    }

    void Cre()
    {
        select = Random.Range(0, 2);
        X = Random.Range(9.6f, 14.0f);
        Y = Random.Range(-2.71f, 3.42f);
        Instantiate(Itemselect[select], new Vector3(X, Y), Quaternion.identity);
        

    }
}
