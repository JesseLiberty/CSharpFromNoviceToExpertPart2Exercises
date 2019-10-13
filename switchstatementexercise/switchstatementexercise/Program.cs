using System;

namespace switchstatementexercise
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
         Switch(42);
         Switch("Life, the universe and everything");
         Switch(3.33333);
         Switch(false);
      }

      public void Switch(object param)
      {
         switch (param)
         {
            case int i when i > 100:
               Console.WriteLine("you passed in a large integer");
               break;
            case int i when i >= 4:
               Console.WriteLine("you passed in a medium integer");
               break;
            case int i when i < 4:
               Console.WriteLine("you passed in a smaller integer");
               break;
            case double d:
               Console.WriteLine("you passed in a double");
               break;
            case string s:
               Console.WriteLine("you passed in a string");
               break;
            case bool b when !b:
               Console.WriteLine("you passed in false");
               break;
            default:
               Console.WriteLine("I don't know what you passed in ");
               break;
         }

         ;
      }
   }
}
