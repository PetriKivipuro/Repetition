﻿using System;

namespace exercise_33
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("Give the first string:");
            string eka = Console.ReadLine();

            Console.WriteLine("Give the second string:");
            string toka = Console.ReadLine();

            if (eka == toka)
            {
                Console.WriteLine("Echo!");
            }
            else
            {
                Console.WriteLine("Nope!");
            }




        }
    }
}
