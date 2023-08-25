using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExplanationSelect : MonoBehaviour
{
    public List<GameObject> FirstButtonselect = new List<GameObject>();
    int select=1;
    [SerializeField] GameObject Second;
    // Start is called before the first frame update
    void Start()
    {
        FirstButtonselect[select].GetComponent<Image>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(!Second.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                select = 0;
                FirstButtonselect[select].GetComponent<Image>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
                FirstButtonselect[select + 1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                select = 1;
                FirstButtonselect[select].GetComponent<Image>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
                FirstButtonselect[select - 1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                select = 0;
                FirstButtonselect[select].GetComponent<Image>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
                FirstButtonselect[select+2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                select = 2;
                FirstButtonselect[select].GetComponent<Image>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
                FirstButtonselect[select - 2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
        }
        

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(select == 0)
            {
                SceneManager.LoadScene("Stage1");
            }
            else if (select == 1)
            {
                GameObject.Find("Panel Chenge").GetComponent<PanelChenge>().NextView();
                select = 2;
                FirstButtonselect[select].GetComponent<Image>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
                FirstButtonselect[select - 2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            }
            else
            {
                GameObject.Find("Panel Chenge").GetComponent<PanelChenge>().CloseView();
                select = 1;
            }
        }
    }
}
