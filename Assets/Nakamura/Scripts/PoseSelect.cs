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
    public List<Sprite> BlackImageselect = new List<Sprite>();

    public List<GameObject> Buttonselect2 = new List<GameObject>();
    public List<Sprite> WhiteImageselect2 = new List<Sprite>();
    public List<Sprite> Imageselect2 = new List<Sprite>();
    public List<Sprite> BlackImageselect2 = new List<Sprite>();

    private Animator warninganim;
    private Animator warninganim2;
    private Animator explanim;
    private Animator explanim2;

    [SerializeField] GameObject warning;
    [SerializeField] GameObject warning2;
    [SerializeField] GameObject expl;
    [SerializeField] GameObject expl2;

    private int select = 0;
    private int select2 = 0;

    public static bool workingNo = false;
    public static bool workingYes = false;
    // Start is called before the first frame update
    void Start()
    {
        warninganim= warning.GetComponent<Animator>();
        warninganim.updateMode = AnimatorUpdateMode.UnscaledTime;
        warninganim2 = warning2.GetComponent<Animator>();
        warninganim2.updateMode = AnimatorUpdateMode.UnscaledTime;
        explanim = expl.GetComponent<Animator>();
        explanim.updateMode = AnimatorUpdateMode.UnscaledTime;
        explanim2 = expl2.GetComponent<Animator>();
        explanim2.updateMode = AnimatorUpdateMode.UnscaledTime;
        expl.SetActive(false);
        expl2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (warning.transform.lossyScale.y !=0.0f)
        {
            if (Input.GetKeyUp(KeyCode.Return))
            {

                warning.transform.localScale = new Vector3(0, 0, 0);
                warning.SetActive(false);
                warning2.SetActive(true);
                warninganim2.SetBool("WarningBL", true);
            }
        }
        

        else if (warning2.transform.lossyScale.y != 0.0f)
        {
            Debug.Log("D");

            if (Input.GetKeyUp(KeyCode.A))
            {
                Buttonselect2[select2].GetComponent<Image>().sprite = Imageselect2[select2];
                select2 = 0;

            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                Buttonselect2[select2].GetComponent<Image>().sprite = Imageselect2[select2];
                select2 = 1;

            }
            Buttonselect2[select2].GetComponent<Image>().sprite = WhiteImageselect2[select2];

            if (Input.GetKey(KeyCode.Return))
            {
                Buttonselect2[select2].GetComponent<Image>().sprite = BlackImageselect2[select2];
            }

            if (Input.GetKeyUp(KeyCode.Return))
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

        else if (expl.transform.lossyScale.y != 0.0f)
        {
            if (Input.GetKeyUp(KeyCode.Return))
            {
                expl.transform.localScale = new Vector3(0,0,0);
                expl.SetActive(false);
                expl2.SetActive(true);
                explanim2.SetBool("ExplBL", true);
                Debug.Log("SD");
            }
        }

        else if (expl2.transform.lossyScale.y != 0.0f)
        {
            Debug.Log("B");
            if (Input.GetKeyUp(KeyCode.Return))
            {
                expl2.transform.localScale = new Vector3(0, 0, 0);
                expl2.SetActive(false);
                explanim2.SetBool("ExplBL", false);
            }
        }

        else
        {
            Debug.Log(select);
            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("A1");
                Buttonselect[select].GetComponent<Image>().sprite = Imageselect[select];
                if (select != 0)
                {
                    select--;
                }

            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log("A2");
                Buttonselect[select].GetComponent<Image>().sprite = Imageselect[select];
                if (select != 2)
                {
                    select++;
                }

            }
            Buttonselect[select].GetComponent<Image>().sprite = WhiteImageselect[select];

            if (Input.GetKey(KeyCode.Return))
            {
                Buttonselect[select].GetComponent<Image>().sprite = BlackImageselect[select];
            }
            if (Input.GetKeyUp(KeyCode.Return))
            {
                Buttonselect[select].GetComponent<Image>().sprite = Imageselect[select];
                Debug.Log(Buttonselect[select].GetComponent<Image>().sprite);
                switch (select)
                {
                    case 0:
                        Time.timeScale = 1;
                        this.gameObject.SetActive(false);
                        break;


                    case 1:
                        
                        expl.SetActive(true);
                        explanim.SetBool("ExplBL", true);
                        break;

                    default:
                        warning.SetActive(true);
                        warninganim.SetBool("WarningBL", true);
                        break;


                }
            }

        }
    }
}
