using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChenge : MonoBehaviour
{    // Update is called once per frame
    bool sound = false;
    void Update()
    {
        AudioSource audio = GetComponent<AudioSource>();
        if (Input.GetKeyDown(KeyCode.Return))
        {
            sound = true;
            audio.Play();
            
        }

        if (!audio.isPlaying && sound)
        {
            SceneManager.LoadScene("TestScene");
        }
    }
}
