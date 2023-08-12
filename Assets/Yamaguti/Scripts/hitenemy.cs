using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitenemy : MonoBehaviour
{
    [SerializeField] GameObject outburst;
    public int Enemyenergy = 3;
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
        Enemyenergy--;
        Debug.Log("energy");
        if (Enemyenergy <= 0)
        {
            if(collider.gameObject.tag !="Nose")
            {
                Instantiate(outburst, this.gameObject.transform.position, Quaternion.identity);
            }
            Debug.Log("Destoy");
            Destroy(gameObject);

        }
    }
}
