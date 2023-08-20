using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public static bool drug;
    [Header("プレイヤーが装着するマスク")]
    [SerializeField] GameObject Mask;
    GameObject Fulcrum;
    GameObject launcher;

    // Start is called before the first frame update
    void Start()
    {
        launcher = GameObject.Find("Launcher");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Fulcrum = GameObject.Find("NoseFulcrum");
        if (other.gameObject.tag == "Mask")
        {
            Instantiate(Mask, Mask.transform.position, Quaternion.identity);
            Fulcrum.tag = "Mask";
        }
        if (other.gameObject.tag == "SuperDrugMove")
        {
            drug = true;
        }
        if (other.gameObject.tag == "Boost")
        {
            Debug.Log("A");
            launcher.tag = "Diffusion";
        }
    }
}
