using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    private float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * speed, 0);//”wŒi‚ð“®‚©‚·
        if (transform.position.x <= -17.31f)//”wŒi‚ª‰æ–ÊŠO‚Éo‚½‚ç‘O‚É–ß‚·
        {
            transform.position = new Vector3(34.57f, 0.0f);
        }
    }
}
