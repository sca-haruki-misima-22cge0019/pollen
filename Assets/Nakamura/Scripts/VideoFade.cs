using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoFade : MonoBehaviour
{
    [SerializeField] float StartTime;
    private float nowtime = 0.0f;
    [SerializeField] GameObject Fadeout;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nowtime+= Time.deltaTime;
        if(nowtime >= StartTime || Input.GetKey(KeyCode.V))
        {
            this.gameObject.GetComponent<Animator>().enabled  = true;
        }

        if(VideoPlay.Feedend >=1)
        {
            //Debug.Log("A");
            Fadeout.GetComponent<Animator>().enabled = true;
            VideoPlay.Feedend = 0;
        }
    }

    void SceneMove()
    {
        SceneManager.LoadScene("VideoScene");
    }
}
