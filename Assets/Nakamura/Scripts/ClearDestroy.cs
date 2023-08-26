using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDestroy : MonoBehaviour
{
    GameObject bos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Bos")
        {
            
            bos = GameObject.Find("Boss");
            BossHp bosHp = bos.GetComponent<BossHp>();
            if(bosHp.death)
            {
                Debug.Log("BO");
                Destroy(gameObject);
            }
        }
    }
}
