using System;

namespace exercise_38
{
    class Program
    {
        public static void Main(string[] args)
        {
            int negativesAmount = 0;
            // Write your code here:
            while (true)
            {
                Console.WriteLine("Give a number:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }
                else if (number < 0)
                {
                    negativesAmount += 1;
                }
            }
            Console.WriteLine("Total amount of negative numbers: " + negativesAmount);



        }
    }
}
