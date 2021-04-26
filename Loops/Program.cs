using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <= 100; i++) // 0 to 100
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 1; i <= 100; i = i + 2) // odds numbers
            //{
            //    Console.WriteLine(i);
            //}

            //ForLoop();

            //WhileLoop();

            //DoWhileLoop();

            //ForEachLoop();

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number.");
            }


            Console.ReadLine();


        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i <= number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }

            }
            return result;
        }
        private static void ForEachLoop()
        {
            string[] students = { "Orçun", "Barış", "Mete" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;

            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
