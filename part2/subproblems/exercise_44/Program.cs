using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:



      int eka = Convert.ToInt32(Console.ReadLine());
      int toka = Convert.ToInt32(Console.ReadLine());

      if (eka < toka)
      {
        Console.WriteLine(eka + " is less than " + toka + ".");
      }
      if (eka > toka)
      {
        Console.WriteLine(eka + " is greater than " + toka + ".");
      }
      if (eka == toka)
      {
        Console.WriteLine(eka + " is equal to " + toka + ".");
      }



    }
  }
}
