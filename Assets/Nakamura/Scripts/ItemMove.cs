using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMove : MonoBehaviour
{
   [SerializeField]float speed =1.0f;
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            transform.Rotate(new Vector3(0.0f, 0.0f, 0.5f));
            transform.position += new Vector3(-speed * Time.deltaTime, 0.0f, 0.0f);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Drug" || other.gameObject.tag =="Nose")
        {
            this.gameObject.SetActive(false);
        }
    }

}
