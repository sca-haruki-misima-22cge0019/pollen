using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCre : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    float X;
    float Y;
    float time;
    float time2;
    int count;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(time);
        
        time += Time.deltaTime;
        count = Random.Range(3, 5);

        int quantity = 1;
        if (quantity <= time)
        {
            for(int e = 0; e<count;e++)
            {
                Cre();
            }
            
            time = 0.0f;
        }
        
        time2 += Time.deltaTime;
        if (EnemyCount.ScreenEnemy <= 5 && time >= 1.0f)
        {
            Cre();
            time2 = 0.0f;
        }
    }
    void Cre()
    {
        X = Random.Range(9.9f, 14.0f);
        Y = Random.Range(-4.5f, 4.5f);
        Instantiate(enemy, new Vector3(X, Y), Quaternion.identity);
    }
}
