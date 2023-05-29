using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning2 : MonoBehaviour
{
    [SerializeField]GameObject Warning2nd;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = Warning2nd.GetComponent<Animator>();
        anim.updateMode = AnimatorUpdateMode.UnscaledTime;
        Warning2nd.transform.localScale = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            this.gameObject.SetActive(false);
            anim.SetBool("WarningBL", true);
        }
    }
}
