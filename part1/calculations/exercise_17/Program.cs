﻿using System;

namespace exercise_17
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Write your code here:
            Console.WriteLine("Give the first number!");
            int eka = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the second number!");
            int toka = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum is " + (eka + toka));
        }
    }
}
