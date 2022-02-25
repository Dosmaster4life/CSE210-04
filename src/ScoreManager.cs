using System;
using System.Collections.Generic;
namespace DefaultNamespace;

public static class ScoreManager    // Methods to alter score total
{
   public static int score = 0;

   // Increases the score
   public static void scoreUp(){
   score += 100; 
   }
   
   // Decreases the score
   public static void scoreDown(){
   score -= 100; 
   }

   // Resets the score to zero
   public static void scoreReset(){
   score = 0; 
   }

   // Divides the score in half
   public static void scoreHalf(){
   score = score/2; 
   }
}