using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Flash : MonoBehaviour
{
    public List<Image> flashselect = new List<Image>();
    public List<Image> workingselect = new List<Image>();
    int select= 0;
    int select2 = 0;
    private Animator anim;
    public static bool workingNo = false;
    public static bool workingYes = false;
    [SerializeField] GameObject warning;
    [SerializeField] GameObject poseobject;
    [SerializeField] GameObject working2;
    // Start is called before the first frame update
    void Start()
    {
        anim = warning.GetComponent<Animator>();
        anim.updateMode = AnimatorUpdateMode.UnscaledTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(working2.transform.lossyScale.y ==0.0f)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                flashselect[select].color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                select--;
                if (select <= 0)
                {
                    select = 0;
                }
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                flashselect[select].color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                select++;
                if (select >= 2)
                {
                    select = 2;
                }
            }
            flashselect[select].color = new Color(0.0f, 0.0f, 0.0f, 0.0f);

            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (select == 0)
                {
                    SceneManager.LoadScene("Explanation");
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
                workingselect[select2].color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                select2--;
                if (select2 <= 0)
                {
                    select2 = 0;
                }
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                workingselect[select2].color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
                select2++;
                if (select2 >= 1)
                {
                    select2 = 1;
                }
            }
            workingselect[select2].color = new Color(0.0f, 0.0f, 0.0f, 0.0f);

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
