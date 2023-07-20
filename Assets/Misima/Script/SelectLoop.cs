using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectLoop : MonoBehaviour
{
    Button _button = default;

    // Start is called before the first frame update
    void Start()
    {
    // ボタンなど選択可能なコンポーネントを取得する
    var selects = GetComponentsInChildren<Selectable>();
        for (var i = 0; i < selects.Length; i++)
        {
            var nav = selects[i].navigation;
            nav.mode = Navigation.Mode.Explicit;
            nav.selectOnUp = selects[i == 0 ? selects.Length - 1 : i - 1];
            nav.selectOnDown = selects[(i + 1) % selects.Length];
            selects[i].navigation = nav;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            
        }
    }
}
