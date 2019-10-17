using System;

namespace PatternMatchingPart1Exercise
{
   class Program
   {
      static void Main(string[] args)
      {
         var runner = new Runner();
         runner.Run();
      }

      public class Runner
      {
         public void Run()
         {
            var fineComputer = new FineComputer();
            var zero = fineComputer.ComputeFine(0);
            Console.WriteLine($"The fine for having no passengers is ${zero}");
         }
      }

      public class FineComputer
      {
         public double ComputeFine(int? numPassengers) =>
            numPassengers switch
            {
               0 => 100.00,
               1 => 40.00,
               2 => 20.00,
               3 => 0.0,
               { } => throw new ArgumentException(message: "Unknown number"),
               null => throw new ArgumentNullException()
            };
      }
   }
}