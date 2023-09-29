using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounce; // 튕김 힘의 세기

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌한 게임 오브젝트가 "Ball" 스크립트를 가지고 있는지 확인
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            // 충돌한 지점의 법선 벡터를 가져옴
            Vector2 normal = collision.GetContact(0).normal;
            
            // 법선 벡터를 이용하여 공에 튕김 힘을 추가
            ball.AddForce(-normal * this.bounce);
        }
    }
}