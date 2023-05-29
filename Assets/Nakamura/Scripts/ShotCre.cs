
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCre : MonoBehaviour
{
    [SerializeField] GameObject Shot;
    [SerializeField] GameObject superShot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(Shot, new Vector3(-7.8f, 0.0f), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(superShot, new Vector3(-7.8f, 0.0f), Quaternion.identity);
        }
    }

}
