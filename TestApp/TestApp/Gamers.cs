using System;
using System.Linq;

namespace Cv5 {
   public class Gamers {
      private Gamer[] _gamers;
      private int _capacity;

      public int CurrentCount { get; private set; }

      public Gamers(int capacity) {
         _capacity = capacity;
         _gamers = new Gamer[capacity];
      }

      public void Add(Gamer gamer) {
         if (IsFull()){
            BoostArray();
         }

         _gamers[CurrentCount++] = gamer;
      }

      private void BoostArray() {
         _capacity = 2 * _capacity;
         var newArray = new Gamer[_capacity];
         Array.Copy(_gamers, 0, newArray, 0, CurrentCount);

         _gamers = newArray;
      }

      public Gamer this[int index] {
         get {
            CheckSize(index);
            return _gamers[index];
         }
      }

      public Gamer[] FindTheBestClub(out FootballClub[] clubs, out int maxGoals) {
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
         while (maxGoals == gamers[k].GoalsNumber){
            k++;
         }
         clubs = new FootballClub[k];
         k = 0;
         while (maxGoals == gamers[k].GoalsNumber){
            clubs[k] = gamers[k].Club;
            k++;
         }

         return gamers;
      }

      private delegate void NumberChangedEventHandler(object sender, EventArgs eventArgs);


      private bool IsFull() {
         return _capacity == CurrentCount;
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