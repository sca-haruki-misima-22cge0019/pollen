using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PoseSelect : MonoBehaviour
{
    public List<GameObject> Buttonselect = new List<GameObject>();
    public List<Sprite> WhiteImageselect = new List<Sprite>();
    public List<Sprite> Imageselect = new List<Sprite>();

    public List<GameObject> Buttonselect2 = new List<GameObject>();
    public List<Sprite> WhiteImageselect2 = new List<Sprite>();
    public List<Sprite> Imageselect2 = new List<Sprite>();
    private Animator warninganim;
    private Animator explanim;
    private Animator explanim2;
    [SerializeField] GameObject warning;
    [SerializeField] GameObject warningPanel;
    [SerializeField] GameObject expl;
    [SerializeField] GameObject expl2;
    private int select = 0;
    private int select2 = 0;
    public static bool workingNo = false;
    public static bool workingYes = false;
    // Start is called before the first frame update
    void Start()
    {
        warninganim = warning.GetComponent<Animator>();
        warninganim.updateMode = AnimatorUpdateMode.UnscaledTime;
        explanim = expl.GetComponent<Animator>();
        explanim.updateMode = AnimatorUpdateMode.UnscaledTime;
        expl.SetActive(false);
        explanim2 = expl2.GetComponent<Animator>();
        explanim2.updateMode = AnimatorUpdateMode.UnscaledTime;
        expl2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (warningPanel.transform.lossyScale.y == 0.0f)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Buttonselect[select].GetComponent<Image>().sprite = Imageselect[select];
                if (select != 0)
                {
                    select--;
                }

            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                Buttonselect[select].GetComponent<Image>().sprite = Imageselect[select];
                if (select != 2)
                {
                    select++;
                }

            }
            Buttonselect[select].GetComponent<Image>().sprite = WhiteImageselect[select];

            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log(expl.transform.localScale);
                /*if (select == 0)
                {
                    expl.SetActive(true);
                    explanim.SetBool("ExplBL", true);
                    if(Input.GetKeyDown(KeyCode.Return) && expl.transform.localScale == new Vector3(12, 7, 1))
                    {
                        expl.SetActive(false);
                        explanim.SetBool("ExplBL", false);
                        expl2.SetActive(true);
                        explanim2.SetBool("ExplBL", true);
                        Debug.Log("SD");
                    }
                    if (Input.GetKeyDown(KeyCode.Return) && expl2.transform.localScale == new Vector3(12, 7, 1))
                    {
                        expl2.SetActive(false);
                        explanim2.SetBool("ExplBL", false);
                    }
                }*/
                if (select == 1)
                {
                    warning.transform.localScale = new Vector3(0, 0, 0);
                    warning.SetActive(true);
                    warninganim.SetBool("WarningBL", true);
                }
                else if (select == 2)
                {
                    Time.timeScale = 1;
                    this.gameObject.SetActive(false);
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Buttonselect2[select2].GetComponent<Image>().sprite = Imageselect2[select2];
                select2 =0;

            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Buttonselect2[select2].GetComponent<Image>().sprite = Imageselect2[select2];
                select2 =1;

            }
            Buttonselect2[select2].GetComponent<Image>().sprite = WhiteImageselect2[select2];

            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (select2 == 0)
                {
                    workingNo = true;
                }
                else
                {
                    workingYes = true;
                }
            }
        }
           
    }
}
