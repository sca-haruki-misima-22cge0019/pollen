using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackG : MonoBehaviour
{
    private const float K_maxLength = 1f;
    private const string K_PropName = "_MainTex";

    [SerializeField]
    private Vector2 m_offsetSpeed;

    private Material m_material;

    void Start()
    {
        if(GetComponent<Image>() is Image i)
        {
            m_material = i.material;
        }
    }
    void Update()
    {
        if(m_material)
        {
            var x = Mathf.Repeat(Time.time * m_offsetSpeed.x, K_maxLength);
            var y = Mathf.Repeat(Time.time * m_offsetSpeed.x, K_maxLength);
            var offset = new Vector2(x,y);
            m_material.SetTextureOffset(K_PropName,offset);
        }
    }

    private void OnDestroy()
    {
        if(m_material)
        {
            m_material.SetTextureOffset(K_PropName,Vector2.zero);
        }
    }
}