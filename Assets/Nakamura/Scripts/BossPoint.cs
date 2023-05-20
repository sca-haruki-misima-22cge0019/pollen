using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPoint : MonoBehaviour
{
    public List<GameObject> nowList = new List<GameObject>();
    public List<GameObject> oriList = new List<GameObject>();

    int rnd;
    int i = 8;
    // Start is called before the first frame update
    void Start()
    {
        rnd = Random.Range(0,i);
        nowList[rnd].gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(i);
        if(Input.GetKeyDown(KeyCode.L))
        {
            i--;
            if (i == 0)
            {
                nowList.AddRange(oriList);
                i = 8;
            }

            nowList[rnd].gameObject.SetActive(false);
            nowList.RemoveAt(rnd);
            rnd = Random.Range(0, i);
            nowList[rnd].gameObject.SetActive(true);
        }
    }
}
