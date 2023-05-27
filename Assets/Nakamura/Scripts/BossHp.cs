using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHp : MonoBehaviour
{
    private int hp;
    private int maxhp = 4;
    [SerializeField] GameObject BosHP;
    [SerializeField] Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1;
        hp = maxhp;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Hp);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "SuperDrug")
        {
            other.gameObject.SetActive(false);
            hp--;
            slider.value = (float)hp / (float)maxhp;
        }
    }
}
