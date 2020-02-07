using System;

namespace exercise_22
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Write your code here:

            Console.WriteLine("Give the first number!");
            double eka = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give the second number!");
            double toka = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give the second number!");
            double third = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The average is " + ((eka + toka + third) / 3));

        }
    }
}
