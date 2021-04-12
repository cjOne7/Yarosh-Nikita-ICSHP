using System;

namespace Cv8 {
   internal class Program {
      public static void Main(string[] args) {
         var table = new MinMaxHashTable<int, int>();
         table.Add(10, 10);
         table.Add(20, 20);
         table.Add(30, 30);
         table.Add(40, 40);
         table.Add(50, 50);
         table.Add(70, 70);
         Console.WriteLine(table.Contains(40));
      }
   }
}