using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBom : MonoBehaviour
{
    [SerializeField] GameObject bom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDisable()
    {
        Instantiate(bom,transform.position, Quaternion.identity);
        Debug.Log("Bom");
    }
}
