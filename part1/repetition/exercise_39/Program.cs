using System;

namespace exercise_39
{
    class Program
    {
        public static void Main(string[] args)
        {
            int amount = 0;
            // Write your code here:
            while (true)
            {
                Console.WriteLine("Give a number:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }
                else
                {
                    amount += number;
                }
            }
            Console.WriteLine("Total sum of numbers: " + amount);
        }
    }
}
