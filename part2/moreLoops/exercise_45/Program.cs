using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int value = 0;
      int ask = Convert.ToInt32(Console.ReadLine());
      // for (int = 0; i < ask; i++)
      // plus console.WriteLine(i);
      //(int value = 0; ei tarvita silloin)
      while (true)
      {
        if (value <= ask)
        {
          Console.WriteLine(value);
          value += 1;
        }
        else
        {
          break;
        }
      }

    }
  }
}
