using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectYES : MonoBehaviour
{
    public void OnClickstartButton() 
    {
        SceneManager.LoadScene("View of the world");
    }
}
