using System;

namespace Cv5 {
   public static class FootballClubInfo {
      private static readonly int Number = Enum.GetNames(typeof(FootballClub)).Length;

      public static string GetName(FootballClub footballClub) {
         return footballClub.ToString();
      }

      public static string GetName(int index) {
         if (index < 0 || index >= Number){
            throw new IndexOutOfRangeException($"Your index '{index}' is not in range [0;{Number}].");
         }

         return ((FootballClub) index).ToString();
      }
   }
}