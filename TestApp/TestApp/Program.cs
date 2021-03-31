using System;

namespace TestApp {
   internal class Program {
      public static void Main(string[] args) {
         Gamers gamers = new Gamers();
         gamers.Add(new Gamer("Ronaldo", FootballClub.RealMadrid, 10));
         gamers.Add(new Gamer("Messi", FootballClub.Barcelona, 10));
         gamers.Add(new Gamer("F1", FootballClub.Chelsea, 8));
         gamers.Add(new Gamer("F2", FootballClub.Arsenal, 3));
         
         
         gamers.FindTheBestClub(out var clubs, out var goals);
         Console.WriteLine(goals);
         Array.ForEach(clubs, club => Console.WriteLine(club));


         // var linkedList = new LinkedList();
         // linkedList.Add(1);
         // linkedList.Add(2);
         // linkedList.Add(3);
         // linkedList.Insert(1, 1000);
         // linkedList[linkedList.Count - 1] = 200;
         // // linkedList.Remove(1);
         // var enumerator = linkedList.GetEnumerator();
         // while (enumerator.MoveNext()){
         //    object o = enumerator.Current;
         //    Console.WriteLine(o);
         // }
         // // for (var i = 0; i < linkedList.Count; i++){
         // //    Console.WriteLine(linkedList[i]);
         // // }
      }
   }
}