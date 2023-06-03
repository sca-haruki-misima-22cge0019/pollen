using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPos : MonoBehaviour
{
    private float larX = 9.44f;
    private bool large = true;
    private float smaX = -9.44f;
    private bool small = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= larX && large)
        {
            EnemyCre.ScreenEnemy++;
            large = false;
        }

        if (this.transform.position.x <= smaX && small)
        {
            EnemyCre.ScreenEnemy--;
            small = false;
        }
    }
}
