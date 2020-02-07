using System;

namespace exercise_31
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("Give a number:");
            int number = Convert.ToInt32(Console.ReadLine());


            if ((number % 2) == 1)
            {
                Console.WriteLine("It is odd.");
            }

            else
            {
                Console.WriteLine("It is even.");
            }

        }
    }
}
