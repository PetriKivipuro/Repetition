using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:


      int numb2 = Convert.ToInt32(Console.ReadLine());
      int number = Convert.ToInt32(Console.ReadLine());

      //int sum = (numb2 + number);

      double squareRoot = Math.Sqrt(number + numb2); //sum
      Console.WriteLine(squareRoot);


    }
  }
}
