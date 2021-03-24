namespace Cv5 {
   public class Gamer {
      public string Name { get; }

      public FootballClub Club { get; }

      public int GoalsNumber { get; }
      
      public Gamer(string name, FootballClub club, int goalsNumber) {
         Name = name;
         Club = club;
         GoalsNumber = goalsNumber;
      }

      public override string ToString() {
         return $"Name: {Name}, club: {Club}, goals: {GoalsNumber}";
      }
   }
}