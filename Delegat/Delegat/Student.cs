using System;

namespace Delegat {
   public class Student {
      public string Name { get; set; }
      public int Number { get; set; }
      public Faculty Faculty { get; set; }

      public override string ToString() {
         return $"Name: {Name}, faculty: {Faculty}, number: {Number}";
      }
   }
}