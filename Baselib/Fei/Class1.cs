using System;

/*
 * This is a library
 */
namespace Fei {
   namespace BaseLib {
      public class Reading {
         /// <summary>
         /// This is a method for reading value from user and convert to int 
         /// </summary>
         /// <param name="message">This is a message for user</param>
         /// <returns>Converted user's input value to int</returns>
         public static int ReadInt(string message) {
            Console.WriteLine(message + ": ");
            return Convert.ToInt32(Console.ReadLine());
         }

         /// <summary>
         /// This is a method for reading value from user and convert to double 
         /// </summary>
         /// <param name="message">This is a message for user</param>
         /// <returns>Converted user's input value to double</returns>
         public static double ReadDouble(string message) {
            Console.WriteLine(message + ": ");
            return Convert.ToInt32(Console.ReadLine());
         }

         /// <summary>
         /// This is a method for reading char from user 
         /// </summary>
         /// <param name="message">This is a message for user</param>
         /// <returns>Returned user's input char</returns>
         public static char ReadChar(string message) {
            Console.WriteLine(message + ": ");
            var str = Console.ReadLine();
            try{
               return str[0];
            }
            catch (IndexOutOfRangeException e){
               Console.WriteLine(e);
               throw;
            }
         }

         /// <summary>
         /// This is a method for reading value from user 
         /// </summary>
         /// <param name="message">This is a message for user</param>
         /// <returns>Returned user's input value</returns>
         public static string ReadString(string message) {
            Console.WriteLine(message + ": ");
            return Console.ReadLine();
         }
      }
   }
}