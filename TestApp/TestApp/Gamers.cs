namespace TestApp {
   public class Gamers {
      public LinkedList LinkedList { get; } = new LinkedList();

      public delegate void NumberChangedEventHandler(int number);

      public event NumberChangedEventHandler NumberChanged;

      protected virtual void OnNumberChanged(int number) {
         NumberChanged?.Invoke(number);
      }

      public void Add(Gamer gamer) {
         LinkedList.Add(gamer);
         OnNumberChanged(LinkedList.Count);
      }

      public Gamer this[int index] {
         get => LinkedList[index] as Gamer;
         set => LinkedList[index] = value;
      }

      public void FindTheBestClub(out FootballClub[] clubs, out int maxGoals) {
         var gamers = new Gamer[LinkedList.Count];
         LinkedList.CopyTo(gamers, 0);

         for (var i = 0; i < LinkedList.Count - 1; i++){
            for (var j = 0; j < LinkedList.Count - i - 1; j++){
               if (gamers[j].GoalsNumber < gamers[j + 1].GoalsNumber){
                  var temp = gamers[j];
                  gamers[j] = gamers[j + 1];
                  gamers[j + 1] = temp;
               }
            }
         }

         maxGoals = gamers[0].GoalsNumber;
         var k = 0;
         while (maxGoals == gamers[k].GoalsNumber){
            k++;
            if (k == LinkedList.Count){
               break;
            }
         }

         clubs = new FootballClub[k];
         k = 0;
         while (maxGoals == gamers[k].GoalsNumber){
            clubs[k] = gamers[k].Club;
            k++;
            if (k == LinkedList.Count){
               break;
            }
         }
      }

      public void Delete(int index) {
         LinkedList.RemoveAt(index);
      }
   }
}