using System;
using System.Text;

namespace NullOperatorsExercise
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
         var puppy = new Dog
         {
            Name = "Charlie"
         };
         TellName(puppy);
         puppy = null;
         TellName(puppy);
      }

      public void TellName(Dog fido)
      {
         string name = fido?.Name ?? "Dog with no name";
         Console.WriteLine(name);

      }
   }
   public class Dog
   {
      public string Name { get; set; }
   }
}
