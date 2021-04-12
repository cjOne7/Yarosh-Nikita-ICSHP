using System;

namespace Cv8 {
   internal class Program {
      public static void Main(string[] args) {
         var table = new MinMaxHashTable<int, int>();
         table.Add(30, 30);
         table.Add(10, 10);
         table.Add(20, 20);
         table.Add(50, 50);
         table.Add(70, 70);
         table.Add(40, 40);
         // Console.WriteLine(table.Remove(40));
         Console.WriteLine($"Min: {table.Min}, max: {table.Max}.");
         
         var enumerator = table.SortedRange(10, 50);
         // var enumerator = table[10, 50];
         while (enumerator.MoveNext()){
            Console.WriteLine(enumerator.Current);
         }
      }
   }
}