using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NWay : MonoBehaviour
{
    public GameObject enemyFireMissilePrefab;

    public int wayNumber;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;i<wayNumber;i++) {
            Instantiate(enemyFireMissilePrefab,transform.position,
                Quaternion.Euler(0,-30+(15*i),0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
