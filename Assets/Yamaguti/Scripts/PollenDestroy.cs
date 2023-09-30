using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PollenDestroy : MonoBehaviour
{
    GameObject end;
    GameOverScene scene;
    // Start is called before the first frame update
    void Start()
    {
        end = GameObject.Find("GameOver");
        scene = end.GetComponent<GameOverScene>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10 || scene.des)
        {
            Debug.Log("sinderu");
            Destroy(gameObject);
        }
    }
}
