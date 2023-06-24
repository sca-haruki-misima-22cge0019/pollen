using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitenemy : MonoBehaviour
{
    public int energy = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        energy--;

        if (energy <= 0)
        {
            Destroy(gameObject);
        }
    }
}
