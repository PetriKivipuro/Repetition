using System;

namespace exercise_15
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Write your code here:
            Console.WriteLine("Give a string:");
            string jono = Console.ReadLine();

            Console.WriteLine("Give an integer:");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give a double:");
            double tupla = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Give a boolean:");
            bool booli = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Your string: " + jono);
            Console.WriteLine("Your integer: " + numero);
            Console.WriteLine("Your double: " + tupla);
            Console.WriteLine("Your boolean: " + booli);



        }
    }
}
