using System;
using System.Diagnostics.CodeAnalysis;

namespace SwitchStatementsExercise
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
         Switcher("Hello world");
         Switcher("Hi");
      }

      public void Switcher(object val)
      {
         switch (val)
         {
            case string s when s.Length > 10:
               Console.WriteLine($"you passed in a long string {s}");
               break;
            case string s when s.Length <= 10:
               Console.WriteLine($"you passed in a short string {s}");
               break;
            default:
               Console.WriteLine("I don't know what you passed in ");
               break;




         }
      }
   }
}
