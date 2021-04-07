using System;

namespace Ping_Pong_Yarosh_v1 {
   public class SelfPractice {
      public int GameId { get; set; }
      public int Score { get; set; }
      public DateTime DateTime { get; set; }

      public SelfPractice(int gameId, int score, DateTime dateTime) {
         GameId = gameId;
         Score = score;
         DateTime = dateTime;
      }

      public override string ToString() {
         return $"Score: {Score}, {DateTime}";
      }
   }
}