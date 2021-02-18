using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Cv1 {
   class Program {
      static void Main(string[] args) {
         // Console.OutputEncoding = Encoding.UTF8;
         // Console.WriteLine("Josef Novák\nJindrišská 16\n111 50, Praha 1");

         // for (int i = 65; i < 91; i++){
         //    Console.WriteLine((char) i);
         // }

         // int j = 65;
         // while (j < 91) {
         //    Console.WriteLine((char) j++);
         // }

         // int k = 65;
         // do{
         //    Console.WriteLine((char) k++);
         // } while (k < 91);

         // Console.WriteLine(CheckPersonalNumber("850126/1158"));
         //Console.WriteLine(CheckPersonalNumber(8512261158));
         PredictNumber();
      }

      private static void PredictNumber() {
         int maxAttempts = 3;
         var rnd = new Random();
         int rndNum = rnd.Next(101);
         //Console.WriteLine(rndNum);
         int counter = 0;
         var gameIsPlaying = true;
         while (gameIsPlaying){
            Console.WriteLine("Enter estimated number:");
            var userNum = Console.ReadLine();
            counter++;
            if (counter == maxAttempts){
               Console.WriteLine("Ups... You lose. Do you want to start again? y/n");
               switch (Console.ReadLine()?.ToLower().Trim()){
                  case "y":
                     Console.Clear();
                     counter = 0;
                     rndNum = rnd.Next(101);
                     //Console.WriteLine(rndNum);
                     break;
                  case "n":
                     gameIsPlaying = false;
                     break;
                  default:
                     Console.WriteLine("Unknown answer. Game is finished.");
                     break;
               }
            }

            try{
               if (rndNum < Convert.ToInt32(userNum)){
                  Console.WriteLine($"Your number is bigger. Your left attempts are {maxAttempts - counter}");
               }
               else if (rndNum > Convert.ToInt32(userNum)){
                  Console.WriteLine($"Your number is lower. Your left attempts are {maxAttempts - counter}");
               }
               else{
                  Console.WriteLine($"You win in {counter} attempt(-s).");
                  gameIsPlaying = false;
               }
            }
            catch (FormatException e){
               Console.WriteLine(e);
               throw;
            }
         }
      }

      private static string CheckPersonalNumber(ulong number) {
         var length = Convert.ToInt32(Math.Ceiling(Math.Log10(number)));
         while (length != 4){
            number /= 10;
            length--;
         }

         ulong month = number % 100;
         if (month > 0 && month < 13){
            return "male";
         }

         if (month > 50 && month < 63){
            return "female";
         }

         return "wrong format";
      }

      private static string CheckPersonalNumber(string number) {
         var regexForMale = new Regex(@"^\d{2}(0[1-9]|1[1-2])\d{2}\/\d{4}$");
         var regexForFemale = new Regex(@"^\d{2}(5[1-9]|6[1-2])\d{2}\/\d{4}$");
         return regexForMale.IsMatch(number) ? "male" : regexForFemale.IsMatch(number) ? "female" : "wrong format";
      }
   }
}