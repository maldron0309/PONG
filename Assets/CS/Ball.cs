using System;
using UnityEngine;
using Random = UnityEngine.Random;


public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetBall();
        AddStartingForce();
    }
    
    public void ResetBall()
    {
        rb.position = Vector3.zero;
        rb.velocity = Vector3.zero;
    }

    /// <summary>
    /// 공에 초기 속도를 부여하는 함수
    /// </summary>
    public void AddStartingForce()
    {
        // x 방향의 초기 속도를 무작위로 설정
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        // y 방향의 초기 속도를 무작위로 설정
        // 50% 확률로 음수 또는 양수 값이 선택됨
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);
        Vector2 dir = new Vector2(x, y);
        rb.AddForce(dir * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        rb.AddForce(force);
    }
    
    
}