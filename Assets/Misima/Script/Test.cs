using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]

public class Test : MonoBehaviour
{
    /// <summary>���̃L�[�������ƃ{�^������������</summary>
    [SerializeField] KeyCode _key = default;
    Button _button = default;

    void Start()
    {
        _button = GetComponent<Button>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            // �N���b�N�͗��������ɐ������邪�A�{�^������̏ꍇ�͉��������_�Ő���������
            _button.onClick.Invoke();
            // �{�^�������������̌����ڂ̕ω����N����
            ExecuteEvents.Execute(_button.gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            ExecuteEvents.Execute(_button.gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerUpHandler);
        }
    }
}
