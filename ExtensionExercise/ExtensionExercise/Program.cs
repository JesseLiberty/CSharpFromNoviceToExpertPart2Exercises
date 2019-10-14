using System;
using System.Collections.Generic;

namespace ExtensionExercise
{
   class Program
   {
      static void Main(string[] args)
      {
         var runner = new Runner();
         runner.Run();
      }
   }

   class Runner
   {
      public void Run()
      {
         var myList = new List<string>
         {
            "HELLO",
            "Udemy",
            "Jesse",
            "Liberty",
            "Rodrigo",
            "Juarez"
         };
         var newList = myList.AllLower();
         foreach (string myString in newList)
         {
            Console.WriteLine(myString);
         }
      }
   }

   public static class StringStuff
   {
      public static List<string> AllLower(this List<string> strings)
      {
         var tempList = new List<string>();
         foreach (string myString in strings)
         {
            var newString = myString.ToLower();
            tempList.Add(newString);
         }

         return tempList;
      }
   }
}
