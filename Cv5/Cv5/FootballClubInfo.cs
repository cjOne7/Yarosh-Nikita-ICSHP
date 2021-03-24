using System;

namespace Cv5 {
   public static class FootballClubInfo {
      private static int _number = Enum.GetNames(typeof(FootballClub)).Length;

      public static string GetName(FootballClub footballClub) {
         return footballClub.ToString();
      }
      
      public static string GetName(int index) {
         return ((FootballClub) index).ToString();
      }
   }
}