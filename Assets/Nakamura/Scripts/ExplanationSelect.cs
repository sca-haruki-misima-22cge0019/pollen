using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExplanationSelect : MonoBehaviour
{
    int select=1;
    [SerializeField] GameObject Second;
    [SerializeField]Image W;
    [SerializeField] Image S;
    [SerializeField] Image K;
    [SerializeField] Image L;
    [SerializeField] Image P;
    [SerializeField] GameObject sp;
    [SerializeField] Image en;
    [SerializeField] GameObject start;
    [SerializeField] GameObject fadeout;
    Animator anim;
    Animator FadeAnim;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            W.enabled = true;
        }
        else
        {
            W.enabled = false;
        }
        if (Input.GetKey(KeyCode.S))
        {
            S.enabled = true;
        }
        else
        {
            S.enabled = false;
        }
        if (Input.GetKey(KeyCode.K))
        {
            K.enabled = true;
        }
        else
        {
            K.enabled = false;
        }
        if (Input.GetKey(KeyCode.L))
        {
            L.enabled = true;
        }
        else
        {
            L.enabled = false;
        }
        if (Input.GetKey(KeyCode.P))
        {
            P.enabled = true;
        }
        else
        {
            P.enabled = false;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            sp.SetActive(true);
        }
        else
        {
            sp.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Return))
        {
            en.enabled = true;
        }
        else
        {
            en.enabled = false;
        }

        if(SceneManager.GetActiveScene().name == "TestScene")
        {
            if (!Second.activeSelf)
            {
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    GameObject.Find("Panel Chenge").GetComponent<PanelChenge>().NextView();
                }
            }
            else
            {
                anim = start.GetComponent<Animator>();
                FadeAnim = fadeout.GetComponent<Animator>();
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    if (anim.enabled)
                    {
                        //FadeAnim.enabled = true;
                        //Invoke("Feed",1.1f);
                        SceneManager.LoadScene("Stage1");
                    }
                    else
                    {
                        anim.enabled = true;
                    }

                }
            }
        }
        
       
    }

    void Feed()
    {
        SceneManager.LoadScene("Stage1");
    }
}
