using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
      int whereTo = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
      int whereFrom = Convert.ToInt32(Console.ReadLine());

      for (int i = whereFrom; i <= whereTo; i++) //mistä -- minne

      {
        Console.WriteLine(i);
      }


    }
  }
}
