using UnityEngine;
using UnityEngine.UI;

public class MoveImageUpDown : MonoBehaviour
{
    public float moveSpeed = 1.0f; // 動きの速さ
    public float moveDistance = 100.0f; // 上下の動きの距離（ピクセル）

    private Image image; // 動かすImage
    private Vector3 initialPosition; // 初期位置
    private bool movingUp = true; // 上に移動中かどうか

    private void Start() {
        image = GetComponent<Image>(); // Imageコンポーネントを取得
        initialPosition = image.rectTransform.localPosition; // 初期位置を保存
    }

    private void Update() {
        // 上下の動きを計算
        float verticalMovement = moveSpeed * Time.deltaTime;
        if(movingUp) {
            // 上に移動
            image.rectTransform.localPosition += new Vector3(0, verticalMovement, 0);

            // 上方向の限界に達したら下に移動する
            if(image.rectTransform.localPosition.y >= initialPosition.y + moveDistance) {
                movingUp = false;
            }
        } else {
            // 下に移動
            image.rectTransform.localPosition -= new Vector3(0, verticalMovement, 0);

            // 下方向の限界に達したら上に移動する
            if(image.rectTransform.localPosition.y <= initialPosition.y - moveDistance) {
                movingUp = true;
            }
        }
    }
}
