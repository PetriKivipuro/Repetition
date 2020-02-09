using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      DivisibleByThreeInRange(1, 9);

    }

    // Write your method here:
    public static void DivisibleByThreeInRange(int beginning, int end)
    {
      //alkuarvolle annetaan nimi i
      //alkuarvo on pienempi tai yhtäsuuri kuin loppuarvo
      // arvo alkuarvoon lisätään +1
      for (int i = beginning; i <= end; i++)
      {
        if (i % 3 == 0)
        {
          Console.WriteLine(i);
        }
      }

    }

  }
}
