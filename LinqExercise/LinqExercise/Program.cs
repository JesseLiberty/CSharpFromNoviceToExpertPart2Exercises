using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
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
         var query = from method in typeof(string).GetMethods()
            orderby method.Name
            group method by method.Name
            into groups
            select new
               {MethodName = groups.Key, MethodOverloads = groups.Count()};

         foreach (var item in query)
         {
            Console.WriteLine(item);
         }
      }
   }
}
