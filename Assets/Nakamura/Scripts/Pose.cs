using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pose : MonoBehaviour
{
    [SerializeField] GameObject poseobject;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        poseobject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            poseobject.SetActive(true);
            Time.timeScale = 0;
        }
    }

}

