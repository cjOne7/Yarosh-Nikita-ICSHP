using System;
using System.Linq;
using System.Text;
using Fei;
using Fei.BaseLib;


namespace Matrix {
   internal class Program {
      private const int MaxSize = 10;
      private static readonly double[] Array = new double[10];
      private static int _pos;

      private const char One = 'i';
      private const char Five = 'v';
      private const char Ten = 'x';
      private const char Fifty = 'l';
      private const char Hundred = 'c';
      private const char FiveHundred = 'd';
      private const char Thousand = 'm';
      
      public static void Main(string[] args) {

         Console.WriteLine(MathConvertor.ArabicDecimalToRoman(49));
         Console.WriteLine(MathConvertor.RomanToArabicDecimal("XLIX"));
         Console.WriteLine();
         // ExtraMath.CalcRoots(3, -14, -5, out var x1, out var x2);
         // Console.WriteLine($"x1: {x1}, x2: {x2}");
         // Console.OutputEncoding = Encoding.UTF8;
         // var isLoop = true;
         //
         // while (isLoop){
         //    Console.WriteLine("\nKonzolové menu:\n"
         //                      + "1 -> Zadaní prvků pole z klávesnice\n"
         //                      + "2 -> Výpis pole na obrazovku\n"
         //                      + "3 -> Utřídění pole vzestupně\n"
         //                      + "4 -> Utřídění pole sestupně\n"
         //                      + "5 -> Hledání minimálního prvku\n"
         //                      + "6 -> Hledání prvního výskytu zadaného čísla\n"
         //                      + "7 -> Hledání posledního výskytu zadaného čísla\n"
         //                      + "0 -> Konec programu\n");
         //    int choice = Convert.ToInt32(Console.ReadLine());
         //    Console.WriteLine();
         //    switch (choice){
         //       case 1:
         //          EnterDouble();
         //          break;
         //       case 2:
         //          TypeArray();
         //          break;
         //       case 3:
         //          SortDownUp();
         //          TypeArray();
         //          break;
         //       case 4:
         //          SortUpDown();
         //          TypeArray();
         //          break;
         //       case 5:
         //          Console.WriteLine(FindMin());
         //          break;
         //       case 6:
         //          Console.WriteLine(FindFirstOccurence());
         //          break;
         //       case 7: 
         //          Console.WriteLine(FindLastOccurence());
         //          break;
         //       case 0:
         //          isLoop = false;
         //          break;
         //       default:
         //          Console.WriteLine("Unknown command.");
         //          break;
         //    }
         // }
      }

      private static int FindLastOccurence() {
         double value = Reading.ReadDouble("Enter searching number");
         for (var i = _pos - 1; i > 0; i--){
            if (Array[i] == value){
               return i;
            }
         }

         return -1;
      }

      private static int FindFirstOccurence() {
         double value = Reading.ReadDouble("Enter searching number");
         for (var i = 0; i < _pos; i++){
            if (Array[i] == value){
               return i;
            }
         }

         return -1;
      }

      private static double FindMin() {
         if (Array.Length > 1){
            double min = Array[0];
            for (int i = 1; i < _pos; i++){
               if (Array[i] < min){
                  min = Array[i];
               }
            }

            return min;
         }

         return Array.Length == 1 ? Array[0] : 0.0;
      }

      private static void SortUpDown() {
         for (var i = 0; i < _pos - 1; i++){
            for (var j = 0; j < _pos - i - 1; j++){
               if (Array[j] < Array[j + 1]){
                  Swap(j);
               }
            }
         }
      }

      private static void SortDownUp() {
         for (var i = 0; i < _pos - 1; i++){
            for (var j = 0; j < _pos - i - 1; j++){
               if (Array[j] > Array[j + 1]){
                  Swap(j);
               }
            }
         }
      }

      private static void Swap(int index) {
         var temp = Array[index];
         Array[index] = Array[index + 1];
         Array[index + 1] = temp;
      }

      private static void EnterDouble() {
         if (_pos < MaxSize){
            double value = Reading.ReadDouble("Your value");
            Array[_pos++] = value;
         }
         else{
            throw new IndexOutOfRangeException("Array is full");
         }
      }

      private static void TypeArray() {
         for (var i = 0; i < _pos; i++){
            Console.WriteLine(Array[i]);
         }
      }
   }
}