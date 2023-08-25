using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverSelect : MonoBehaviour
{
    [SerializeField] Sprite push;
    [SerializeField] Sprite up;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GetComponent<Image>().sprite =push;
        }
        if (Input.GetKeyUp(KeyCode.Return))
        {
            GetComponent<Image>().sprite = up;
            SceneManager.LoadScene("TitleScene");
        }
    }
}
