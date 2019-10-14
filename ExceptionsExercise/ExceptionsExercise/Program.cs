using System;
using System.Threading.Tasks;

namespace ExceptionsExercise
{
   class ExceptionTest
   {
      static void Main(string[] args)
      {
         var runner = new Runner();
         runner.Run();
      }
   }
}

class Runner
{
   public void Run()
   {
      try
      {
         Console.WriteLine("Opening file...");
         Console.WriteLine("Entering Run...");

         Task.Delay(2000);
         Concatenator("5","2");
         string x = "hello ";
         Concatenator(x, null);
         Console.WriteLine("Exiting Run...");

      }
      catch (Exception e)
      {
         Console.WriteLine(e.Message);

      }
      finally
      {
         Console.WriteLine("Closing file...");

      }
   }

   private string Concatenator(string left, string right)
   {

      return left.ToString() + right.ToString();
   }


}
