using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHp : MonoBehaviour
{
    private int hp;
    private int maxhp = 4;
    private float nowhp;
    [SerializeField] Slider slider;
    public bool damage = false;
    public bool death = false;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1;
        hp = maxhp;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(death);
    }


    void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.tag == "SuperDrug")
    {
        damage = true;
        other.gameObject.SetActive(false);
        StartCoroutine(DecreaseHPAnimation(maxhp, --hp));
        Debug.Log(slider.value);
    }
}
    IEnumerator DecreaseHPAnimation(int oldHP, int newHP)
{
    Debug.Log(hp);
    if (hp == 0)
    {
        Debug.Log("A");
        damage = false;
        death = true;
    }
    else
    {

        Debug.Log("S");

    }

    nowhp = (float)newHP / (float)oldHP;
    //Debug.Log(nowhp);
    while (slider.value >= nowhp)
    {
        slider.value -= 0.01f;
        yield return null;
    }
    //Debug.Log(slider.value);
}
}