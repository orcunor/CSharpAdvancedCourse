using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            var result = Add2(2, 5);
            var result1 = Add2(4);
            Console.WriteLine(result1);
            Console.WriteLine(result);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3( number1 , number2);
            Console.WriteLine(result2); // 130 
            Console.WriteLine(number1); // 20  ref veya out keywordüyle kullanılınırsa 30 olarak set edildiği için method içinde değişir

            Console.WriteLine(Multiply(3,4,5));

            Console.WriteLine(Add4(2,4,5,6,7,8,9,0,4,3,2,23,5546,7));


            Console.ReadLine();


            // ref - out   değer tiplerini referans tipi olarak göndermek için kullanılır. ref number1 = 20, int number2 = 100, out kulanırken method içinde number1 set edilmeli.
            // ref number1 , out number1 , ref int number1 , out int number1 number1 = 30; method içinde set edilmeli örnek.
        }

        static void Add() // void returns nothing just do something
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2=30) // this method will return int
        {
            return number1 + number2;
        }

        static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1, int number2) // Method overloading yapıyorum bir alt methodla
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3) // Method overloading
        {
            return number1 * number2 * number3;
        }

        static int Add4(int number1, int number2) // Method Overloading
        {
            return number1 + number2;
        }

        static int Add4(int number1, int number2,int number3) // Method overloading
        {
            return number1 + number2 + number3;
        }

        static int Add4(params int[] numbers) // Birden fazla int değer alabilir. int dizisi params keywordü ile kulanılınır.
        {
            return numbers.Sum();
            
        }
    }
}
