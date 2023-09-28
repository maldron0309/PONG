using UnityEngine;

public class ComputerPaddle : Paddle
{
    [SerializeField]
    private Rigidbody2D ball;

    private void FixedUpdate()
    {
        // 만약 공이 오른쪽으로 움직이고 있을 때
        if (ball.velocity.x > 0f)
        {
            // 공이 패들 위에 있으면 위로 이동
            if (ball.position.y > rb.position.y)
            {
                rb.AddForce(Vector2.up * speed);
            }
            // 공이 패들 아래에 있으면 아래로 이동
            else if (ball.position.y < rb.position.y)
            {
                rb.AddForce(Vector2.down * speed);
            }
        }
        // 만약 공이 왼쪽으로 움직이고 있을 때
        else
        {
            // 패들이 위쪽에 있으면 아래로 이동
            if (rb.position.y > 0f)
            {
                rb.AddForce(Vector2.down * speed);
            }
            // 패들이 아래쪽에 있으면 위로 이동
            else if (rb.position.y < 0f)
            {
                rb.AddForce(Vector2.up * speed);
            }
        }
    }


}