﻿using System;

namespace exercise_37
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            // Write your code here:
            while (true)
            {
                Console.WriteLine("Give a number:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number != 0)
                {
                    sum += 1;
                }
                if (number == 0)
                {
                    Console.WriteLine("Total amount of numbers: " + sum);
                    break;
                }
            }
        }

    }
}
