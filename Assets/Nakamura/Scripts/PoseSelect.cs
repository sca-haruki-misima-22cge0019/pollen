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
    private Animator anim;
    [SerializeField] GameObject warning;
    [SerializeField] GameObject warningPanel;
    private int select = 0;
    private int select2 = 0;
    public static bool workingNo = false;
    public static bool workingYes = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = warning.GetComponent<Animator>();
        anim.updateMode = AnimatorUpdateMode.UnscaledTime;
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
                if (select == 0)
                {
                    Debug.Log("Setumei");
                }
                else if (select == 1)
                {
                    warning.transform.localScale = new Vector3(0, 0, 0);
                    warning.SetActive(true);
                    anim.SetBool("WarningBL", true);
                }
                else
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
