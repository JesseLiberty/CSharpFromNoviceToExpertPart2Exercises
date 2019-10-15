using System;
using System.Linq;
using System.Threading;

namespace DeferredExecutionExercise
{
   class Program
   {
      static void Main(string[] args)
      {
         Counter();
      }

      public static void Counter()
      {
         var query = Enumerable.Range(0, 1000000)
            .Select(x =>
            {
               Thread.Sleep(1000);
               return x;
            });

         foreach (var num in query)
         {
            Console.WriteLine(num);
         }
      }
   }
}