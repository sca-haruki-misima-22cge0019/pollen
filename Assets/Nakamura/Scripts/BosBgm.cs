using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BosBgm : MonoBehaviour
{
    [SerializeField] GameObject BosHp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BossHp bosHp = BosHp.GetComponent<BossHp>();
        if(bosHp.death)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.volume = 0.1f;
        }
    }
}
