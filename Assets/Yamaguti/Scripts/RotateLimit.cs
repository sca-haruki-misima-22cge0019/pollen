using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�ŏ��p�x(-180�`180")]
    private float MinAngle;

    [SerializeField]
    [Tooltip("�ő�p�x(-180�`180")]
    private float MaxAngle;

    [SerializeField]
    [Tooltip("��]����X�s�[�h")]
    private float rotationSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���E�L�[�̓��͂��擾
        float horizontal = Input.GetAxis("Horizontal");
        // ���݂�GameObject��Y�������̊p�x���擾
        float currentYAngle = transform.eulerAngles.z;
        // ���݂̊p�x��180���傫���ꍇ
        if (currentYAngle > 180)
        {
            // �f�t�H���g�ł͊p�x��0�`360�Ȃ̂�-180�`180�ƂȂ�悤�ɕ␳
            currentYAngle = currentYAngle - 360;
        }
        // (���݂̊p�x���ŏ��p�x�ȏォ�L�[���͂�0����(���L�[����)) �܂��� (���݂̊p�x���ő�p�x�ȉ����L�[���͂�0���傫��(�E�L�[����))�̎�
        if ((currentYAngle >= MinAngle && horizontal < 0) || (currentYAngle <= MaxAngle && horizontal > 0))
        {
            // Y������ɉ�]������
            transform.Rotate(new Vector3(0, 0, horizontal * rotationSpeed));
        }
    }
}
