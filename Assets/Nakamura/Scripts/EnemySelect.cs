using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Pollen CURVE(Clone)")
        {
            ScoreCount.score +=100;
        }

        if (other.gameObject.name == "Pollen LINE(Clone)")
        {
            ScoreCount.score += 200;
        }

        if (other.gameObject.name == "Pollen TRACKING(Clone)")
        {
            ScoreCount.score += 300;
        }
    }
}
