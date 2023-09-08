using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PopoutUI : MonoBehaviour
{
    Transform tf;

    [Header("モーションの長さ(持続時間)")]
    [SerializeField]
    float duration = 0.8f;

    [Header("モーション開始までのディスプレー")]
    [SerializeField]
    [Range(0,10.0f)]
    float delay = 0;

    [Header("最小Scale(モーション時間時のサイズ)")]
    [SerializeField]
    Vector3 scaleMin = new Vector3(0,0,0);

    [Header("最大cale(デフォルトScale * 1.3程度の値を入れる)")]
    [SerializeField]
    Vector3 scakeMax = new Vector3(1.3f,1.3f,1.3f);

    Vector3 defaultScale;

    Coroutine popout;

    static readonly float Modifier = Mathf.PI * 0.725f;

    float elapsedTime;

    WaitForSeconds delayWait;

    private void Awake()
    {
        tf = transform;
        defaultScale = tf.localScale;

        if(delay != 0)
        {
            delayWait = new WaitForSeconds(delay);
        }
    }

    void OnEnable()
    {
        if(popout != null)
        {
            StopCoroutine(popout);
        }

        popout = StartCoroutine(Popout());
    }

    IEnumerator Popout()
    {
        elapsedTime = 0;

        if(delay != 0)
        {
            tf.localScale = scaleMin;
            yield return delayWait;
        }

        while(true)
        {
            elapsedTime += Time.deltaTime;

            tf.localScale = Vector3.Lerp(scaleMin,scakeMax,Mathf.Sin(elapsedTime / duration * Modifier));

            if(duration <= elapsedTime)
            {
                tf.localScale = defaultScale;

                popout = null;
                yield break;
            }
            yield return null;
        }
    }
}
