using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SelectYES : MonoBehaviour
{
    [SerializeField]Fade fade;
    public void NextScene() 
    {
        Action act = () => SceneManager.LoadScene("View of the world");
     //   float time = 1f;
    }

    //fade.FadeIn(time,act);
}
