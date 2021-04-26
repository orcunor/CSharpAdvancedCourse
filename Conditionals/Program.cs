using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            var number1 = 20;
            Console.WriteLine(number1 == 20 ? "Number is 20" : "Number is not 20"); // Single Line if

            if (number < 10)
            {
                Console.WriteLine("Number is smaller than 10");
            }
            else if (number == 10)
            {
                Console.WriteLine("number is 10");
            }
            else if (number == 21)
            {
                Console.WriteLine("number is 21");
            }
            else
            {
                Console.WriteLine("Number is greater than 10 ");
            }

            var number2 = 11;

            switch (number2)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 20:
                    Console.WriteLine("number is 20");
                    break;
                default:
                    Console.WriteLine("number is not 10 or 20");
                    break;
            }


            if (number2 >= 0 && number2 <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number2 > 100 && number2 <= 200)
            {
                Console.WriteLine("Number is between 100-200 ");
            }
            else if (number2 > 200 || number2 < 0)
            {
                Console.WriteLine("Number is greater than 200 or less than 0");
            }


            int number3 = 98;
            if (number3 < 100)
            {
                if (number3 >= 90 && number3 <= 99)
                {
                    Console.WriteLine("number is between 90-99");
                }
            }



            // 6.Metotlar dan devam.

        }
    }
}
