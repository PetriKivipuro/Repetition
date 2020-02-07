using System;

namespace exercise_21
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


            Console.WriteLine("The average is " + ((eka + toka) / 2));
        }
    }
}
