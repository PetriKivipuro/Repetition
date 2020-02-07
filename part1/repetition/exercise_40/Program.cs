using System;

namespace exercise_40
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            int amount = 0;

            // Write your code here:
            while (true)
            {
                Console.WriteLine("Give a number:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number != 0)
                {
                    sum += number; // sum = sum + number;
                    amount = amount + 1;

                }

                if (number == 0)
                {
                    //nämä consolet voi laittaa tähän tai while loopin jälkeen
                    //Console.WriteLine("Total sum of numbers: " + sum);
                    //Console.WriteLine("Total amount of numbers: " + amount);
                    break;
                }



            }
            Console.WriteLine("Total sum of numbers: " + sum);
            Console.WriteLine("Total amount of numbers: " + amount);
        }
    }
}
