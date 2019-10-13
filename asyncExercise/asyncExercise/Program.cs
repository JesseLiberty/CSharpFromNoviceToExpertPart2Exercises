using System;
using System.Threading;
using System.Threading.Tasks;

namespace asyncExercise
{
   class Program
   {
      static async Task Main(string[] args)
      {
         Console.WriteLine("1: Main started...");
         await TakesALongTime();
         Console.WriteLine("3: Main finished...");

         Thread.Sleep(3000);
      }

      public static async Task TakesALongTime()
      {
         await Task.Delay(500);
         Console.WriteLine("2: Finish TakesALongTime");
      }
   }
}
