using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOperatorsExercise
{
   class Program
   {
      static void Main(string[] args)
      {
         var numberList = new List<int>
         {
            1, 2, 1, 3, 3, 4, 3, 6, 2, 7, 3, 4, 12, 9
         };

         var numbers = numberList
            .Distinct()
            .Skip(2)
            .Take(5)
            .Select(x => x);

         foreach (var number in numbers)
         {
            Console.Write(number + " ");
         }


      }
   }
}