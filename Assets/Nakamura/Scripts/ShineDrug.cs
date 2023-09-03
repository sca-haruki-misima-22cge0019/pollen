using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShineDrug : MonoBehaviour
{
    [SerializeField] GameObject Barrier;
    [SerializeField] GameObject Frontdrug;
    [SerializeField] GameObject Launcher;
    FireBullet fireBullet;
    [SerializeField] GameObject Nose;
    hit hp;
    DamageWall damageWall;
    [SerializeField] GameObject Bos;
    BossHp bossHp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fireBullet = Launcher.GetComponent<FireBullet>();
        if(!Barrier.activeSelf && !fireBullet.reload)
        {
            Frontdrug.SetActive(true);
        }
        else
        {
            Frontdrug.SetActive(false);
        }

        hp = Nose.GetComponent<hit>();
        damageWall = Nose.GetComponent<DamageWall>();
        bossHp = Bos.GetComponent<BossHp>();
        if (hp.energy <= 0 || bossHp.death || damageWall.damage)
        {
            Frontdrug.SetActive(false);
        }


    }
}
