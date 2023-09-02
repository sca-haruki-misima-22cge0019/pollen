using UnityEngine;
using UnityEngine.UI;

public class MoveImageUpDown : MonoBehaviour
{
    public float moveSpeed = 1.0f; // �����̑���
    public float moveDistance = 100.0f; // �㉺�̓����̋����i�s�N�Z���j

    private Image image; // ������Image
    private Vector3 initialPosition; // �����ʒu
    private bool movingUp = true; // ��Ɉړ������ǂ���

    private void Start() {
        image = GetComponent<Image>(); // Image�R���|�[�l���g���擾
        initialPosition = image.rectTransform.localPosition; // �����ʒu��ۑ�
    }

    private void Update() {
        // �㉺�̓������v�Z
        float verticalMovement = moveSpeed * Time.deltaTime;
        if(movingUp) {
            // ��Ɉړ�
            image.rectTransform.localPosition += new Vector3(0, verticalMovement, 0);

            // ������̌��E�ɒB�����牺�Ɉړ�����
            if(image.rectTransform.localPosition.y >= initialPosition.y + moveDistance) {
                movingUp = false;
            }
        } else {
            // ���Ɉړ�
            image.rectTransform.localPosition -= new Vector3(0, verticalMovement, 0);

            // �������̌��E�ɒB�������Ɉړ�����
            if(image.rectTransform.localPosition.y <= initialPosition.y - moveDistance) {
                movingUp = true;
            }
        }
    }
}
