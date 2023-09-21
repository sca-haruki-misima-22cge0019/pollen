using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleSelect : MonoBehaviour
{
    public List<GameObject> FirstButtonselect = new List<GameObject>();
    public List<Sprite> FirstImageselect = new List<Sprite>();
    int Firstselect = 0;
    [SerializeField]GameObject Exit;

    public List<GameObject> SecondButtonselect = new List<GameObject>();
    public List<Sprite> SecondImageselect = new List<Sprite>();
    public int Secondselect = 0;

    private Animator StartAnim;
    private Animator ReturnAnim;
    // Start is called before the first frame update
    void Start()
    {
        FirstButtonselect[Firstselect].GetComponent<Image>().sprite = FirstImageselect[Firstselect];
        SecondButtonselect[Secondselect].GetComponent<Image>().sprite = SecondImageselect[Secondselect+2];

        StartAnim = FirstButtonselect[0].GetComponent<Animator>();
        ReturnAnim = FirstButtonselect[1].GetComponent<Animator>();
        StartAnim.SetBool("ButtomBL", true);
    }

    // Update is called once per frame
    void Update()
    {
        if(!Exit.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Firstselect = 1;
                ReturnAnim.SetBool("ButtomBL", true);
                StartAnim.SetBool("ButtomBL", false);
                FirstButtonselect[Firstselect - 1].GetComponent<Image>().sprite = FirstImageselect[Firstselect + 1];
                FirstButtonselect[Firstselect].GetComponent<Image>().sprite = FirstImageselect[Firstselect];
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                Firstselect = 0;
                ReturnAnim.SetBool("ButtomBL", false);
                StartAnim.SetBool("ButtomBL", true);
                FirstButtonselect[Firstselect].GetComponent<Image>().sprite = FirstImageselect[Firstselect];
                FirstButtonselect[Firstselect + 1].GetComponent<Image>().sprite = FirstImageselect[Firstselect + 3];

            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (Firstselect == 0)
                {
                    Debug.Log("E");
                    SceneManager.LoadScene("View of the world");
                }
                else
                {
                    Exit.SetActive(true);
                }
            }
        }
        
        
        else
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Secondselect = 1;
                SecondButtonselect[Secondselect].GetComponent<Image>().sprite = SecondImageselect[Secondselect+2];
                SecondButtonselect[Secondselect-1].GetComponent<Image>().sprite = SecondImageselect[Secondselect-1];
            }

            
            if (Input.GetKeyDown(KeyCode.S))
            {
                Secondselect = 0;
                SecondButtonselect[Secondselect].GetComponent<Image>().sprite = SecondImageselect[Secondselect + 2];
                SecondButtonselect[Secondselect + 1].GetComponent<Image>().sprite = SecondImageselect[Secondselect + 1];

            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (Secondselect == 0)
                {
                    SecondButtonselect[Secondselect].GetComponent<Image>().sprite = SecondImageselect[Secondselect + 4];
                    GameObject.Find("Panel").GetComponent<AnimatedDialog>().BACK();
                }
                else
                {
                    SecondButtonselect[Secondselect].GetComponent<Image>().sprite = SecondImageselect[Secondselect +4];
                    Invoke("End",0.5f);
                    
                }
            }
            SecondButtonselect[Secondselect].GetComponent<Image>().sprite = SecondImageselect[Secondselect +2];
        }
    
    }

    public void End()
    {
        Application.Quit();
    }
}
