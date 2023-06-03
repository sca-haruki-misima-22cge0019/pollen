using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetBullet2 : MonoBehaviour
{
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
    }

    public void OnThis()
    {
        gameObject.SetActive(false);
        count += 1;
        SetCountText();
    }
    public void SetCountText()
    {
        if (count >= 3)
        {
            SceneManager.LoadScene("GameClearSceneStage2");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
