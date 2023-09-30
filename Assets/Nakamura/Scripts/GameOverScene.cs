using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
    public bool des;
    // Start is called before the first frame update
    void Start()
    {
        des = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void End()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    void Destroy()
    {
        des = true;
    }
}
