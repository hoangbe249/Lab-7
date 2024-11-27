using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeController : MonoBehaviour
{
    Rigidbody2D rb;

    public float speedMove;

    private Ballon ball;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        Move();
        Shoot();
    }

    private void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(moveX, moveY);

        rb.linearVelocity = direction * speedMove;
    }
    void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(ball != null)
            {
                Destroy(ball.gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("ballon"))
        {
            ball = collision.GetComponent<Ballon>();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ballon"))
        {
            ball = null;
        }
    }
}
