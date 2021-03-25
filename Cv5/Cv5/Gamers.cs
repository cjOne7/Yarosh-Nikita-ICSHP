using System;
using System.Linq;

namespace Cv5 {
   public class Gamers {
      
      private Gamer[] _gamers;
      public int Capacity { get; private set; }
      public int CurrentCount { get; private set; }
      
      public delegate void NumberChangedEventHandler(int number);
      public event NumberChangedEventHandler NumberChanged;

      protected virtual void OnNumberChanged(int number) {
         NumberChanged?.Invoke(number);
      }

      public Gamers(int capacity) {
         Capacity = capacity;
         _gamers = new Gamer[capacity];
      }

      public void Add(Gamer gamer) {
         if (IsFull()){
            BoostArray();
         }

         _gamers[CurrentCount++] = gamer;
         OnNumberChanged(CurrentCount);
      }

      private void BoostArray() {
         Capacity = 2 * Capacity;
         var newArray = new Gamer[Capacity];
         Array.Copy(_gamers, 0, newArray, 0, CurrentCount);

         _gamers = newArray;
      }

      public Gamer this[int index] {
         get {
            CheckSize(index);
            return _gamers[index];
         }
      }

      public void FindTheBestClub(out FootballClub[] clubs, out int maxGoals) {
         var gamers = new Gamer[CurrentCount];
         Array.Copy(_gamers, 0, gamers, 0, CurrentCount);

         for (var i = 0; i < CurrentCount - 1; i++){
            for (var j = 0; j < CurrentCount - i - 1; j++){
               if (gamers[j].GoalsNumber < gamers[j + 1].GoalsNumber){
                  var temp = gamers[j];
                  gamers[j] = gamers[j + 1];
                  gamers[j + 1] = temp;
               }
            }
         }

         maxGoals = gamers[0].GoalsNumber;
         var k = 0;
         while (maxGoals == gamers[k++].GoalsNumber){
            if (k == CurrentCount){
               break;
            }
         }
         clubs = new FootballClub[k];
         k = 0;
         while (maxGoals == gamers[k].GoalsNumber){
            clubs[k] = gamers[k].Club;
            k++;
            if (k == CurrentCount){
               break;
            }
         }
      }

      private bool IsFull() {
         return Capacity == CurrentCount;
      }

      public void Delete(int index) {
         CheckSize(index);
         _gamers = _gamers.Where((gamer, i) => i != index).ToArray();
         CurrentCount--;
      }

      private void CheckSize(int index) {
         if (index < 0 || index > CurrentCount){
            throw new IndexOutOfRangeException($"Your index '{index}' is not in range [0;{CurrentCount}].");
         }
      }
   }
}