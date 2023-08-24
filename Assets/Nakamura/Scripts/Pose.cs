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
            AudioSource audio = GetComponent<AudioSource>();
            audio.volume = 0.2f;
            poseobject.SetActive(true);
            Time.timeScale = 0;
        }

        if(Time.timeScale == 1)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.volume = 0.3f;
        }
    }

}

