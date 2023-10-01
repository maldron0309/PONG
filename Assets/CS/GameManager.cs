using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public Ball ball;
   
   public Paddle playerPaddle;
   public Paddle computerPaddle;
   
   public TextMeshProUGUI playerScoreText;
   public TextMeshProUGUI computerScoreText;
   
   public GameObject winText;
   public GameObject loseText;
   
   
   // 플레이어 점수
   private int playerScore;
   // 컴퓨터 점수
   private int computerScore;

   public void PlayerScores()
   {
      
      playerScore++;
      this.playerScoreText.text = playerScore.ToString();

      if (playerScore >= 15)
      {
         winText.SetActive(true);
      }
      
      ResetRound();
      
   }

   public void ComputerScores()
   {
      computerScore++;
      this.computerScoreText.text = computerScore.ToString();
      
      if (computerScore >= 15)
      {
         loseText.SetActive(true);
      }
      
      ResetRound();
      
   }

   private void ResetRound()
   {
      this.playerPaddle.ResetPosition();
      this.computerPaddle.ResetPosition();
      this.ball.AddStartingForce();
      this.ball.ResetBall();
   }
}
