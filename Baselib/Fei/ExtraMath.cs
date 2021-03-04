using System;

namespace Fei {
   public class ExtraMath {
      public static double GetRandomDouble(int seed, int min = 0, int max = 10) {
         var random = new Random(seed);
         return random.Next(min, max);
      }

      public static bool CalcRoots(double a, double b, double c, out double x1, out double x2) {
         double discriminant = Math.Pow(b, 2) - 4 * a * c;
         if (discriminant > 1){
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return true;
         }

         if (discriminant == 0){
            x1 = x2 = -b / (2 * a);
            return true;
         }

         x1 = x2 = double.NaN;
         return false;
      }
   }
}