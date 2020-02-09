using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintUntilNumber(5);

    }

    // Write your method here:
    public static void PrintUntilNumber(int number)
    {
      int index = 1;
      while (index <= number) // muista, että < ja = jotta saa sen viimeisen numeron tulostettua!!!
      {
        Console.WriteLine(index);
        index++;
      }
    }

  }
}
