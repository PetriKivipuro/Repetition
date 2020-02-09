using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
      Console.WriteLine("How many times?");
      int times = Convert.ToInt32(Console.ReadLine());

      PrintPhrase(times);

    }

    // Write your method here:
    public static void PrintPhrase(int manyTimes)
    {

      for (int miksitaa = 0; miksitaa < manyTimes; miksitaa++)
      {
        Console.WriteLine("In a hole in the ground there lived a method");
      }
      //int miksitaa = 0;
      //while (miksitaa < manyTimes)
      //{
      //  Console.WriteLine("In a hole in the ground there lived a method");
      //  miksitaa++;
      //}

    }
  }
}
