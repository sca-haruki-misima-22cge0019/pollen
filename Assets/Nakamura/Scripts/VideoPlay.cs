using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlay : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;
    private float nowtime = 0.0f;
    public static int Feedend = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        nowtime +=Time.deltaTime;
        if(((nowtime >= 5.0f)&& !videoPlayer.isPlaying)|| Input.GetKeyDown(KeyCode.Return))
        {
            //Debug.Log("A");
            this.gameObject.GetComponent<Animator>().enabled = true;
            return;
        }
    }

    void FadeOut()
    {
        Feedend++;
        SceneManager.LoadScene("TitleScene");
    }
}
