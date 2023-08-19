
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BosMove : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        //this.gameObject.transform.position.y = new Vector3(25,5,0);
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position -= new Vector3(Time.deltaTime * speed, 0.0f);
        if (this.gameObject.transform.position.x < 6.5f)
        {
            speed = 0.0f;
        }
    }
}
