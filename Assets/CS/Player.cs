using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Paddle
{
    private Vector2 direction;

    private void Update()
    {
        // 위로 이동
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            direction = Vector2.up;
        // 아래로 이동
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            direction = Vector2.down;
        else
            direction = Vector2.zero;
        
    }

    private void FixedUpdate()
    {
        Vector2 newPosition = rb.position + direction * this.speed * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);
    }
}
