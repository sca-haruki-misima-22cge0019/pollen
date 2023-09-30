using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoMove : MonoBehaviour
{
    float time;
    [SerializeField] float starttime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= starttime)
        {
            SceneManager.LoadScene("VideoScene");
            time = 0.0f;
        }

    }
}
