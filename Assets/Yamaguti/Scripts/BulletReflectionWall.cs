using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletReflectionWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Trigger�ŐڐG�����I�u�W�F�N�g��
        // �S�ă{�[���Ƃ݂Ȃ����Ƃɂ���
        var rb = other.GetComponent<Rigidbody>();
        if (rb == null) return;

        // ���˃x�N�g���i���x�j
        var inDirection = rb.velocity;
        // �@���x�N�g��
        var inNormal = transform.up;
        // ���˃x�N�g���i���x�j
        var result = Vector3.Reflect(inDirection, inNormal);

        // �o�E���h��̑��x���{�[���ɔ��f
        rb.velocity = result;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



/*private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Bullet"))
    {
        Rigidbody bullet = collision.rigidbody;
        if (bullet != null)
        {
            ContactPoint contactPoint = collision.GetContact(0);

            bullet.velocity = Vector3.Reflect(collision.relativeVelocity, contactPoint.normal);
        }
    }
}*/