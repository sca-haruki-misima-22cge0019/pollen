using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public static bool drug;
    [Header("プレイヤーが装着するマスク")]
    [SerializeField] GameObject Mask;
    private int mask = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Mask" && mask == 0)
        {
            Instantiate(Mask, Mask.transform.position, Quaternion.identity);
            mask++;
            Invoke("MaskMove",3.0f);
        }
        if (other.gameObject.tag == "SuperDrugMove")
        {
            drug = true;
        }
        if (other.gameObject.tag == "Boost")
        {
            
        }
    }

    void MaskMove()
    {
        mask = 0;
    }
}
