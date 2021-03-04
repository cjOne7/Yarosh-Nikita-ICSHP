using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fei {
   public static class MathConvertor {
      private const char One = 'I';
      private const char Five = 'V';
      private const char Ten = 'X';
      private const char Fifty = 'L';
      private const char Hundred = 'C';
      private const char FiveHundred = 'D';
      private const char Thousand = 'M';

      public static string DecimalToBinary(int number) {
         var binaryBuilder = new StringBuilder();
         while (number > 1){
            binaryBuilder.Append(number % 2);
            number /= 2;
         }

         binaryBuilder.Append(number);
         return new string(binaryBuilder.ToString().Reverse().ToArray());
      }

      public static int BinaryToDecimal(string number) {
         int degree = 0;
         double decimalNumber = 0;
         for (var i = number.Length - 1; i >= 0; i--){
            decimalNumber += number[i] == '1' ? Math.Pow(2, degree) : 0;
            degree++;
         }

         return Convert.ToInt32(decimalNumber);
      }

      public static int RomanToArabicDecimal(string number) {
         var convertedValuesList = new List<int>();
         foreach (var character in number.ToUpper()){
            switch (character){
               case One:
                  convertedValuesList.Add(1);
                  break;
               case Five:
                  convertedValuesList.Add(5);
                  break;
               case Ten:
                  convertedValuesList.Add(10);
                  break;
               case Fifty:
                  convertedValuesList.Add(50);
                  break;
               case Hundred:
                  convertedValuesList.Add(100);
                  break;
               case FiveHundred:
                  convertedValuesList.Add(500);
                  break;
               case Thousand:
                  convertedValuesList.Add(1000);
                  break;
            }
         }

         int arabic = 0;
         for (var i = 0; i < convertedValuesList.Count - 1; i++){
            if (convertedValuesList[i] >= convertedValuesList[i + 1]){
               arabic += convertedValuesList[i];
            }
            else{
               arabic -= convertedValuesList[i];
            }
         }

         arabic += convertedValuesList[convertedValuesList.Count - 1];
         return arabic;
      }

      public static string DecimalToRoman(int number) {
         if ((number < 0) || (number > 3999))
            throw new ArgumentOutOfRangeException("Insert value betwheen 1 and 3999!");
         if (number < 1) return string.Empty;
         if (number >= 1000) return Thousand + DecimalToRoman(number - 1000);
         if (number >= 900) return "CM" + DecimalToRoman(number - 900);
         if (number >= 500) return FiveHundred + DecimalToRoman(number - 500);
         if (number >= 400) return "CD" + DecimalToRoman(number - 400);
         if (number >= 100) return Hundred + DecimalToRoman(number - 100);
         if (number >= 90) return "XC" + DecimalToRoman(number - 90);
         if (number >= 50) return Fifty + DecimalToRoman(number - 50);
         if (number >= 40) return "XL" + DecimalToRoman(number - 40);
         if (number >= 10) return Ten + DecimalToRoman(number - 10);
         if (number >= 9) return "IX" + DecimalToRoman(number - 9);
         if (number >= 5) return Five + DecimalToRoman(number - 5);
         if (number >= 4) return "IV" + DecimalToRoman(number - 4);
         return One + DecimalToRoman(number - 1);
      }
   }
}