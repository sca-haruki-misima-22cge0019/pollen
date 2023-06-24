using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletReflectionWall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Triggerで接触したオブジェクトは
        // 全てボールとみなすことにする
        var rb = other.GetComponent<Rigidbody2D>();
        if (rb == null) return;

        // 入射ベクトル（速度）
        var inDirection = rb.velocity;
        // 法線ベクトル
        var inNormal = transform.up;
        // 反射ベクトル（速度）
        var result = Vector2.Reflect(inDirection, inNormal);

        // バウンド後の速度をボールに反映
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