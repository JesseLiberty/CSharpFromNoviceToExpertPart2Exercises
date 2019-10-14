using System;
using System.Xml.Linq;

namespace OperatorOverloadingExercise
{
   class Program
   {
      static void Main(string[] args)
      {
         var Charlie = new Dog("Charlie", 101);
         var Milo = new Dog("Milo", id: 781);
         DoCompare(Charlie);
         
      }

      public static void DoCompare(Dog newDog)
      {
         var Charles = new Dog("Charles", 101);
         Console.WriteLine($"{newDog == Charles}");
      }
   }

   public class Dog
   {
      public int TagId { get; set; }
      public string Name { get; set; }

      public Dog(string name, int id)
      {
         Name = name;
         TagId = id;
      }

      public static bool operator ==(Dog left, Dog right)
      {
         if (left.TagId == right.TagId)
         {
            return true;
         }
         else
         {
            return false;
         }
      }

      public static bool operator !=(Dog left, Dog right)
      {
         if (left.TagId == right.TagId)
         {
            return false;
         }
         else
         {
            return true;
         }
      }

   }
}
