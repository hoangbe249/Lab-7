using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{
    private SpriteRenderer sprite;
    private Rigidbody2D rb;

    public Sprite[] sprites;
    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        sprite.sprite = sprites[Random.Range(0,sprites.Length)];
        rb.gravityScale = Random.Range(-1f, -.5f);
    }


}
