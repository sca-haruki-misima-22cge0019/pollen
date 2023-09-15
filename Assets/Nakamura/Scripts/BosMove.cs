
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BosMove : MonoBehaviour
{
    [SerializeField] float speed;
    GameObject fade;
    FadeIn fadein;
    // Start is called before the first frame update
    void Start()
    {
        //this.gameObject.transform.position.y = new Vector3(25,5,0);
        fade = GameObject.Find("FadeIn");
        fadein = fade.GetComponent<FadeIn>();
    }

    // Update is called once per frame
    void Update()
    {
        if(fadein.movestart)
        {
            this.gameObject.transform.position -= new Vector3(Time.deltaTime * speed, 0.0f);
            if (this.gameObject.transform.position.x < 6.5f)
            {
                speed = 0.0f;
            }
        }

    }
}
