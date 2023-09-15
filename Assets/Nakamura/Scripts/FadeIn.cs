using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField] Fade fade;
    [SerializeField] Image imageToFade; // �����x��ύX������Image�R���|�[�l���g
    private  float fadetime = 2.0f; // �t�F�[�h�̎������ԁi�b�j
    private float currentAlpha = 1.0f; // ���݂̃A���t�@�l 
    public bool movestart = false;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Fadestart",0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(movestart);
    }

    private IEnumerator Fade()
    {
        float time = 0.0f;

        while(time <fadetime)
        {
            currentAlpha = Mathf.Lerp(1.0f, 0.0f, time / fadetime);
            Color newColor = imageToFade.color;
            newColor.a = currentAlpha;
            imageToFade.color = newColor;

            time += Time.deltaTime;
            yield return null;
        }
        movestart = true;
    }

    void Fadestart()
    {
        fade.FadeIn(3.0f, () => print("�t�F�[�h�C������"));
        StartCoroutine(Fade());
    }
}
