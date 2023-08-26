using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitenemy : MonoBehaviour
{
    [SerializeField] GameObject outburst;
    [Header("íºêiå^â‘ï≤")]
    [SerializeField] GameObject StraightEnemy;
    [Header("í«îˆå^â‘ï≤")]
    [SerializeField] GameObject TrackingEnemy;
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
                if(this.gameObject == StraightEnemy)
                {
                    ScoreCount.score += 22;
                }
                else if (this.gameObject == TrackingEnemy)
                {
                    ScoreCount.score += 13;
                }
                else
                {
                    ScoreCount.score += 30;
                }
            }
            Debug.Log("Destoy");
            Destroy(gameObject);

        }
    }
}
