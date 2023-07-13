using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackG : MonoBehaviour
{
    //�o�b�N�O���E���h�𓮂���

    [SerializeField]
    float scrollSpeed = -1;

    Vector2 cameraRecrMin;

    // Start is called before the first frame update
    void Start()
    {
        //�J�����͈͂̎擾
        cameraRecrMin = Camera.main.ViewportToWorldPoint(new Vector2(Camera.main.transform.position.x,0));
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        transform.Translate(Vector2.right * scrollSpeed * Time.deltaTime);//x�������ɃX�N���[��
        //�J�����̍��[�����S�ɏo����A�E�[�ɏu�Ԉړ�
        if (transform.position.x < (cameraRecrMin.x - Camera.main.transform.position.x) * 2)
        {
            transform.position = new Vector2((Camera.main.transform.position.x - cameraRecrMin.x)*2,
                transform.position.y);
        }
    }
}
