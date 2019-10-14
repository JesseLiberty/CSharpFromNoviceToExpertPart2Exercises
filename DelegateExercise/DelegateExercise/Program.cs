using System;

namespace DelegateExercise
{
   class Program
   {
      static void Main(string[] args)
      {
         var runner = new Runner();
         runner.Run();
      }
   }

   public class Runner
   {
      public void Run()
      {

         var converter = new Converter();
         Converts converts = converter.Convert;
         Console.WriteLine($"{converts(5, "Jesse")}");
      }
   }

   delegate string Converts(int left, string right);

   public class Converter
   {
      
      public string Convert(int left, string right)
      {
         return left.ToString() + " " + right;
      }

   }
}
