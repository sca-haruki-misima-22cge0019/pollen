using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolling : MonoBehaviour
{
    [SerializeField] GameObject Nose;
    [SerializeField] float speed;
    [SerializeField] float rotaspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SnotMove rool;
        rool = Nose.GetComponent<SnotMove>();
        if (rool.GameOverRoll)
        {
            transform.Rotate(new Vector3(0.0f, 0.0f, -rotaspeed));
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
