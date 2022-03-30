using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    Rigidbody2D rb;
    private float x;
    private float y;
    SpriteRenderer sr;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        Vector2 moveInput = new Vector2(x, y);
        direction = moveInput.normalized * speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * Time.fixedDeltaTime);
        if (x < 0)
            sr.flipX = true;
        if (x > 0)
            sr.flipX = false;

    }
}
  