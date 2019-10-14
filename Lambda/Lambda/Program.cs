using System;

namespace Lambda
{
   class Program
   {
      static void Main(string[] args)
      {
         Func<double, double, double> divider = (l, r) => l / r;

         Console.WriteLine($"Dividing 5 / 7 {divider(5, 7)}");

      }
   }
}
