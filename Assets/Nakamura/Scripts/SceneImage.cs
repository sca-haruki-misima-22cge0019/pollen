using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneImage : MonoBehaviour
{
   
    public List<GameObject> sceneselect = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
      
        if (SceneManager.GetActiveScene().name == "Stage1")
        {

            sceneselect[2].SetActive(true);
            sceneselect[5].SetActive(true);
            sceneselect[8].SetActive(true);

        }
        if (SceneManager.GetActiveScene().name == "Stage2")
        {

            sceneselect[0].SetActive(true);
            sceneselect[3].SetActive(true);
            sceneselect[6].SetActive(true);
            
        }
        if (SceneManager.GetActiveScene().name == "Bos")
        {
            sceneselect[1].SetActive(true);
            sceneselect[4].SetActive(true);
            sceneselect[7].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
