using System;
using System.Collections.Generic;

namespace TestApp {
   internal class Program {
      public static void Main(string[] args) {
         var linkedList = new LinkedList();
         linkedList.Add(1);
         linkedList.Add(2);
         linkedList.Add(3);
         linkedList.Insert(1, 1000);
         linkedList[linkedList.Count - 1] = 200;
         
         linkedList.Remove(1);
         for (var i = 0; i < linkedList.Count; i++){
            Console.WriteLine(linkedList[i]);
         }
         
         var list = new LinkedList<object>();
         
      }
   }
}