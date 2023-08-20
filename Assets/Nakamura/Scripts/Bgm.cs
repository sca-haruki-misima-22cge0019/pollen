using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bgm : MonoBehaviour
{
    private static bool music = false;
    // Start is called before the first frame update
    private  void Awake()
    {
        if (music)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            music = true;
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name != "TitleScene" && SceneManager.GetActiveScene().name != "TestScene")
        {
            Debug.Log("S");
            AudioSource audio = GetComponent<AudioSource>();
            audio.volume = 0;
        }
        else
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.volume = 1;
        }
    }
}
