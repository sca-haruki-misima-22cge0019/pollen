using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFadeInOut : MonoBehaviour
{
    public Fade fade;
    [SerializeField] GameObject select;
    TitleSelect titleSelect;
    // Start is called before the first frame update
    void Start()
    {
        titleSelect = select.GetComponent< TitleSelect>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && titleSelect.Secondselect ==1)
        {
            fade.FadeIn(0.5f,()=>print("�t�F�[�h�C������"));
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            fade.FadeOut(0.5f,() => print("�t�F�[�h�A�E�g����"));
        }
    }
}
