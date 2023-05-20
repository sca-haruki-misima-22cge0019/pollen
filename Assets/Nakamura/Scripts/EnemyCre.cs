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
    float time3;
    public static  int ScreenEnemy = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(time3);
        
        time += Time.deltaTime;

       float quantity = 0.3f;
        if (quantity <= time)//0.3•b‚²‚Æ‚Éƒ‰ƒ“ƒ_ƒ€‚È’l‚ğo‚µA‚»‚Ì’l‚Ì‰ñ”•ª“G‚ğ¶¬‚·‚é
        {
            int count = Random.Range(3, 5);
            for (int e = 0; e<count;e++)
            {
                Cre();
            }
            
            time = 0.0f;
        }

        time2 += Time.deltaTime;
        if (ScreenEnemy <= 5 && time2 >= 1.0f)//‰æ–Ê‚É‰f‚Á‚Ä‚¢‚é“G‚ª5ŒÂˆÈ‰º‚©‚ÂŠÔ‚ª‚P•bˆÈãŒo‰ß‚µ‚Ä‚éê‡‚Í“G‚ğ¶¬‚·‚é
        {
            Cre();
        }
        time2 = 0.0f;

        time3 += Time.deltaTime;
        if (15.0f <=time3)
        {
            for (int e = 0; e <20 ; e++)
            {
                Cre();
            }
            time3 = 0.0f;
        }
        

    }
    void Cre()
    {
        X = Random.Range(9.6f, 14.0f);
        Y = Random.Range(-4.5f, 4.5f);
        Instantiate(enemy, new Vector3(X, Y), Quaternion.identity);
    }
}
