using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Poseshot : MonoBehaviour
{
    [SerializeField] GameObject super;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Bos")
        {
            super.SetActive(true);
        }
    }
}
