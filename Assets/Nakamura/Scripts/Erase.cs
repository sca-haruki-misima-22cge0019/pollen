using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Bos = GameObject.Find("Boss");
        BossHp bosHp = Bos.GetComponent<BossHp>();
        if(bosHp.death)
        {
            gameObject.SetActive(false);
        }
    }
}
