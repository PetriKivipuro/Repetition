using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int sum = 0;
      int amount = 0;
      int even = 0;
      int odd = 0;

      Console.WriteLine("Give numbers:");
      while (true)
      {
        int numbers = Convert.ToInt32(Console.ReadLine());

        if (numbers == -1)
        {
          break;
        }

        sum = sum + numbers;
        amount = amount + 1;


        if ((numbers % 2) == 0)
        {
          even++;
        }

        else
        {
          odd++;
        }




      }
      Console.WriteLine("Thx! Bye!");
      Console.WriteLine("Sum: " + sum);
      Console.WriteLine("Numbers: " + amount);
      Console.WriteLine("Average: " + (double)sum / amount);
      Console.WriteLine("Even: " + even);
      Console.WriteLine("Odd: " + odd);


    }
  }
}
