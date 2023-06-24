using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarningTitle : MonoBehaviour
{
    private Animator backanim;
    private Animator titleanim;
    private float time;
    private bool timecount = false;
    [SerializeField] GameObject Titleback;
    // Start is called before the first frame update
    void Start()
    {
        backanim =this.gameObject.GetComponent<Animator>();
        backanim.updateMode = AnimatorUpdateMode.UnscaledTime;

        titleanim = Titleback.GetComponent<Animator>();
        titleanim.updateMode = AnimatorUpdateMode.UnscaledTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(PoseSelect.workingNo)
        {
            backanim.SetBool("WarningBL", false);
            PoseSelect.workingNo = false;
        }

        if(PoseSelect.workingYes)
        {
            Titleback.SetActive(true);
            titleanim.SetBool("TitleBL", true);
            timecount = true;
            PoseSelect.workingYes = false;
        }


        if (timecount)
        {
            time += Time.deltaTime + Time.unscaledDeltaTime;
            Debug.Log(time);
            if(time >=2.0f)
            {
                SceneManager.LoadScene("Title");
            }
        }
    }
}
