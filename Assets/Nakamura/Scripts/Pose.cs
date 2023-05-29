using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pose : MonoBehaviour
{
    [SerializeField]GameObject poseobject;
    [SerializeField] GameObject warning;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = warning.GetComponent<Animator>();
        anim.updateMode = AnimatorUpdateMode.UnscaledTime;
        poseobject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            poseobject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Expl()
    {
        SceneManager.LoadScene("Explanation");
    }

    public void Title()
    {
        warning.transform.localScale = new Vector3(0, 0, 0);
        warning.SetActive(true);
        anim.SetBool("WarningBL",true);
    }

    public void GameReturn()
    {
        Time.timeScale = 1;
        poseobject.SetActive(false);
    }
}
