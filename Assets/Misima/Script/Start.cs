using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Operation explanation");
    }
}
