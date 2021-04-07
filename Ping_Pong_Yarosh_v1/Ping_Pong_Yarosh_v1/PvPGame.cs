using System;

namespace Ping_Pong_Yarosh_v1 {
   public class PvPGame {
      public int GameId { get; set; }
      public string Player1 { get; set; }
      public string Player2 { get; set; }
      public string Winner { get; set; }
      public DateTime DateTime { get; set; }

      public PvPGame(int gameId, string player1, string player2, string winner, DateTime dateTime) {
         GameId = gameId;
         Player1 = player1;
         Player2 = player2;
         Winner = winner;
         DateTime = dateTime;
      }

      public override string ToString() {
         return $"{Player1} vs. {Player2}, {DateTime}. Player {Winner} wins!";
      }
   }
}