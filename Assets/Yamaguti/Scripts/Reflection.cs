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
            
            // 衝突した法線ベクトルを取得
            Vector2 normal = collision.contacts[0].normal;
            
            // 入射ベクトルを取得
            Vector2 inDirection = rb.velocity.normalized;
            
            // 反射ベクトルを計算
            Vector2 reflectDirection = Vector2.Reflect(inDirection, normal);
            
            // 反射後の速度を適用
            rb.velocity = reflectDirection * rb.velocity.magnitude;
            
        }
    }
}

