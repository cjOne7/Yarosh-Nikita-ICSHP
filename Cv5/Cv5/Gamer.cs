namespace Cv5 {
   public class Gamer {
      public string Name { get; set; }

      public FootballClub Club { get; set;}

      public int GoalsNumber { get; set;}
      
      public Gamer(string name, FootballClub club, int goalsNumber) {
         Name = name;
         Club = club;
         GoalsNumber = goalsNumber;
      }

      public Gamer() {
         
      }

      public override string ToString() {
         return $"Name:{Name},club:{Club},goals:{GoalsNumber}";
      }
   }
}