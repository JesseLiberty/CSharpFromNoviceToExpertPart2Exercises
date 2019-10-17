using System;
using System.Runtime.InteropServices.ComTypes;

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
            var normal = ComputeFine(1);
            Console.WriteLine($"The fine for having one passengers is ${normal}");
            var taxi = new Taxi()
               {numPassengers = 1};

            var fine = ComputeFine(taxi.numPassengers);
               var discount = ComputeDiscount(taxi);
            var total = fine - discount;
            Console.WriteLine($"Total fine for this taxi is ${total}");
         }

         public double ComputeDiscount(object vehicle) =>
            vehicle switch
            {
               Car car => 0.0,
               Taxi taxi => 10.00,
               EmergencyVehicle emergencyVehicle => emergencyVehicle.numPassengers switch
               {
                  0 => 50.00,
                  _ => 40.00,
               },
               _ => 0.0,
            };

         public double ComputeFine(int? numPassengers) =>
            numPassengers switch
            {
               0 => 100.00,
               1 => 40.00,
               2 => 20.00,
               3 => 0.0,
               _ => 0.0,
            };
      }
   }

   public class Car
   {
      public int numPassengers;
   }

   public class Taxi
   {
      public int numPassengers;
   }

   public class EmergencyVehicle
   {
      public int numPassengers;
   }
}