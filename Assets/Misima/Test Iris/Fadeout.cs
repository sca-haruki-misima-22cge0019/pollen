using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Fadeout : MonoBehaviour
{
    public GameObject Panelfade;
    Image fadealpha;
    private float alpha;
    private bool fadeout;
    public int SceneNo;

    // Start is called before the first frame update
    void Start()
    {
        fadealpha = Panelfade.GetComponent<Image>();
        alpha = fadealpha.color.a;
        fadeout = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(fadeout == true)
        {
            FadeOut();
        }
    }

    void FadeOut()
    {
        alpha += 0.01f;
        fadealpha.color = new Color(0,0,0,alpha);
        if(alpha >= 1)
        {
            fadeout = false;
        }
    }
}
