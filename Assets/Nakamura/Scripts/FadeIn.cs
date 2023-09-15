using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField] Fade fade;
    [SerializeField] Image imageToFade; // 透明度を変更したいImageコンポーネント
    private  float fadetime = 2.0f; // フェードの持続時間（秒）
    private float currentAlpha = 1.0f; // 現在のアルファ値 
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
        fade.FadeIn(3.0f, () => print("フェードイン完了"));
        StartCoroutine(Fade());
    }
}
