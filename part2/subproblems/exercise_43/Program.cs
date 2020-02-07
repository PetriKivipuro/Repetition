using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      int value = Convert.ToInt32(Console.ReadLine());

      while (true)
      {
        if (value < 0)
        {
          // debugg Console.WriteLine("Tulos: " + value * -1);
          Console.WriteLine(value * -1);
          break;
        }
        else
        {
          Console.WriteLine(value);
          break;
        }
      }

    }
  }
}
