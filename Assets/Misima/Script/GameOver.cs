using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    GameObject energy;
    int enegyflag = 3;
    private void Start() 
    {
        Invoke("ChangeScene", 1.5f);
        this.energy = GameObject.Find("energy");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeScene()
    {
        if(enegyflag == 0) 
        {
            SceneManager.LoadScene("Game Over Scene");
        }
    }
}
