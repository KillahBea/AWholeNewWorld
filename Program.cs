using System;

namespace AWholeNewWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      var min = 1;
      var max = 100;
      var estimate = 0;
      var input = "";
      Console.WriteLine("Pick a number between 1 and 100");
      //if guess is too high choose lower
      while (input.ToLower() != "yes")
      {
        estimate = (min + max) / 2;
        Console.WriteLine($"Is your number {estimate} or lower or higher?");
        input = Console.ReadLine();
        // if (input == "Yes")

        // // {
        // Console.WriteLine("Got it!");
        // // }
        if (input == "lower")
        {
          // do the lower stuff
          max = estimate;
          // estimate = (min + max) / 2;
        }
        else if (input == "higher")
        {
          min = estimate;
          // << Escape here - if the "if" condition is met, escape the loop here >>;
          // estimate = (max + min) / 2;
        }
        // do the higher stuff
      }

      //if guess is too low choose higher
      //if guess is on the money=correct

    }
  }
}
