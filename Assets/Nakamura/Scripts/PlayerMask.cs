using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMask : MonoBehaviour
{
    GameObject Fulcrum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MaskEnd()
    {
        Fulcrum = GameObject.Find("NoseFulcrum");
        Fulcrum.tag = "Untagged";
    }
}
