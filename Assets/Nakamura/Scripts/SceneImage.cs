using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneImage : MonoBehaviour
{
    public List<GameObject> sceneselect = new List<GameObject>();
    public static int Scene;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Stage1")
        {
            Scene = Random.Range(0,2);
            sceneselect[Scene].SetActive(true);
            sceneselect[Scene+3].SetActive(true);
            sceneselect[Scene+6].SetActive(true);

        }
        if (SceneManager.GetActiveScene().name == "Stage2")
        {
            int scene2 = Scene+1;
            Debug.Log(scene2);
            if (scene2>=3)
            {
                scene2 = 0;
            }
            Debug.Log(scene2);
            sceneselect[scene2].SetActive(true);
            sceneselect[scene2+3].SetActive(true);
            sceneselect[scene2+6].SetActive(true);
            Scene = scene2;
        }
        if (SceneManager.GetActiveScene().name == "Bos")
        {
            int scene3 = Scene+1;
            Debug.Log(scene3);
            if (scene3 >= 3)
            {
                scene3 = 0;
            }
            Debug.Log(scene3);
            sceneselect[scene3].SetActive(true);
            sceneselect[scene3 + 3].SetActive(true);
            sceneselect[scene3 + 6].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
