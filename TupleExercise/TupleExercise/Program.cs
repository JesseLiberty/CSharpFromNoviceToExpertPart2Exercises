using System;
using System.Collections.Generic;

namespace TupleExercise
{
   class Program
   {
      static void Main(string[] args)
      {
         var myList = new List<int>
         {
            1, 2, 3, 2, 4, 1, 5, 6, 2,5
         };

         var (first,last) = GetFirstAndLast(myList);
         Console.WriteLine(first.ToString());
         Console.WriteLine(last.ToString());

      }

      public static (int first, int last) GetFirstAndLast(List<int> theList)
      {
         theList.Sort();
         int first = theList[0];
         int last = theList[^1];  // ^1 == count back 1 from count

         return (first, last);
      }
   }
}
