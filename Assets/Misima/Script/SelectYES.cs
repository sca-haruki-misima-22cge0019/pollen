using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectYES : MonoBehaviour
{

    private void OnClickstartButton() 
    {
        SceneManager.LoadScene("View of the world");
    }
}
