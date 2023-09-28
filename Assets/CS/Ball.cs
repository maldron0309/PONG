using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed;
    private Rigidbody2D rb;
    
    void Start()
    {   
        rb = GetComponent<Rigidbody2D>();
        Launch();
    }


    private void Launch()
    {
        float x = Random.Range(-5, +5) == 0 ? -1 : 1;
        float y = Random.Range(-5, +5) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed + x, speed + y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Borders")
        {
            rb.velocity = -rb.velocity; 
        }
    }
}