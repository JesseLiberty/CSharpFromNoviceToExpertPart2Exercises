using System;

namespace EventsExercise
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
         var button = new Button("Click me");
         var page = new Page(button);
         button.OnClick(this, new EventArgs());

      }
   }

   public class Button
   {
      public string Name { get; set; }
      

      public Button(string name)
      {
         Name = name;
      }

      //EventArgs is supplied by .NET and holds data the event might need
      public delegate void ClickHandler(object sender, EventArgs e);

      public event ClickHandler Click;

      public void OnClick(object sender, EventArgs e)
      {

         Click?.Invoke(this, e);
      }
   }

   public class Page
   {
      public Page(Button button)
      {

         button.Click += new Button.ClickHandler(DoClick);
      }

      public void DoClick(object sender, EventArgs e)
      {
         Console.WriteLine($"You clicked me!");
      }
   }

 }
