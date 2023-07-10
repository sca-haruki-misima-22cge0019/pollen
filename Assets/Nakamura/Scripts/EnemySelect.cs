using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySelect : MonoBehaviour
{
    [Header("íºêiå^â‘ï≤")]
    [SerializeField] GameObject StraightEnemy;
    [Header("ÉEÉFÅ[Éuå^â‘ï≤")]
    [SerializeField] GameObject WaveEnemy;
    [SerializeField] GameObject WaveEnemy2;
    [Header("í«îˆå^â‘ï≤")]
    [SerializeField] GameObject TrackingEnemy;
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
        if (other.gameObject.name == StraightEnemy.name+ "(Clone)")
        {
            ScoreCount.score +=22;
        }

        if (other.gameObject.name == WaveEnemy.name + "(Clone)" || other.gameObject.name == WaveEnemy2.name + "(Clone)")
        {
            ScoreCount.score += 30;
        }

        if (other.gameObject.name == TrackingEnemy.name + "(Clone)")
        {
            ScoreCount.score += 13;
        }
    }
}
