using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecailBullet : MonoBehaviour
{
    [SerializeField] GameObject sphereObject;

    // Start is called before the first frame update
    void Start()
     {
        Invoke("SelfDestroy",30.0f);

        sphereObject.SetActive(false);
        Invoke("SphereSet", 10.0f);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-0.1f,0,0));
    }

    void SelfDestroy()
    {
        Destroy(gameObject);
    }
    void SphereSet()
    {
        sphereObject.SetActive(true);
    }
}