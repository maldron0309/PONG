using System;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 dir;

    private void Update()
    {
        // 위로 이동
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            dir = Vector2.up;
        // 아래로 이동
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            dir = Vector2.down;
        // 움직이지 않음
        else
            dir = Vector2.zero;
    }

    private void FixedUpdate()
    {
        // 움직일 방향 벡터의 크기가 0이 아닌 경우에만 AddForce 추가
        if (dir.sqrMagnitude != 0)
        {
            // rb에 방향 벡터에 this.speed를 곱한 AddForce를 추가
            rb.AddForce(dir * this.speed);
        }
    }
}