using System;

namespace ParsingExercise
{
   class Program
   {
      static void Main(string[] args)
      {
         var myString = "42";
         var myConverter = int.TryParse(myString, out var meaningOfLife);
         Console.WriteLine($"Converted to {meaningOfLife}");
      }
   }
}
