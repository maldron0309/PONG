using System;
using UnityEngine;
public abstract class Paddle : MonoBehaviour
{
    public float speed = 10.0f;
    
    // Paddle클래스를 상속한 클래스들만 사용가능하게
    protected Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    public void ResetPosition()
    {
        rb.position = new Vector2(rb.position.x, 0.0f);
        rb.velocity = Vector2.zero;
    }
}