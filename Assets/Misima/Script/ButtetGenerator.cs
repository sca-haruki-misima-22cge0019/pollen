using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtetGenerator : MonoBehaviour
{
    public GameObject SuperBulletPrefab;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta = Time.deltaTime;
        if(delta >= 1.0f)
        {
            delta = -1.0f;
            GameObject sphere = Instantiate(SuperBulletPrefab) as GameObject;
            sphere.transform.position = new Vector3(0,5,0);
        }
    }
}
