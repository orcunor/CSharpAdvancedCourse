using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            // Value Types

            int number1 = 5;
            int number2 = 3;
            int number3 = 4;
            int sum = number3 + number2 + number1;

            Console.WriteLine("number 1 is :{0}, number 2 is: {1}, number 3 is: {2}",number1,number2,number3);
            Console.WriteLine("Sum is: " +sum);

            // Numeric types

            int num = 2147483647;  // int range is -2147483648 to 2147483647  32-bits
            long x = -9223372036854775808; // long range is -9223372036854775808 to 9223372036854775807  64-bits
            short y = -32768;  // short range is -32768 to 32767. 16-bits
            byte z = 255; // byte range is  0 - 255. 8-bits
            double number4 = 10; // can define integer
            double number5 = 20.45; // 64-bits . dan sonra 15 16 karakter tutabiliyor.

            decimal number6 = 10.4m; // For financial records etc bank  . dan sonra 28 29 karakter tutabilir. Para hesaplamalarında iyidir kullanlır.

            Console.WriteLine(Days.Friday); // Magic stringden kurtuluyoruz. Her yerden fridayi değiştirmemiz gerekicekti normalde. Enum kullanarak tek enum içinden değiştirsek yeterli.

            var number7 = 10;
            Console.WriteLine(number7.GetType()); // System.Int32

            var orcun = "Orçun"; // System.String
            Console.WriteLine(orcun.GetType());
         



            // Logical type

            bool isAlive = true;
            bool isDead = false;

            char character = 'A';
            char gender = 'M';

            Console.WriteLine("Character is : {0}",(int)character); // output is 65 ASCII table









        }

        enum Days
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday

        }
    }
}
