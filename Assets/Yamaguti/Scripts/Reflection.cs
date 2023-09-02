using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflection : MonoBehaviour
{
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit1");
        if (collision.gameObject.CompareTag("Border"))
        {
            
            // �Փ˂����@���x�N�g�����擾
            Vector2 normal = collision.contacts[0].normal;
            
            // ���˃x�N�g�����擾
            Vector2 inDirection = rb.velocity.normalized;
            
            // ���˃x�N�g�����v�Z
            Vector2 reflectDirection = Vector2.Reflect(inDirection, normal);
            
            // ���ˌ�̑��x��K�p
            rb.velocity = reflectDirection * rb.velocity.magnitude;
            
        }
    }
}

