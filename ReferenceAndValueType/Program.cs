using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            // class,string,interface,abstract referance types
            // int,long,char,double etc.. value types

            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2); // 10
            Console.WriteLine(number1); // 30  değer type olduğu için bir şey değişmez number1 i sonradan değiştirdiğimiz halde.

            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" }; //101. örnek ref numarası
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" }; //102. örnek ref numarası
            cities2 = cities1; // 102 yi 101 yaptık. Artık 102 yi tutan bir şey yok. Garbage collector 102 yi uçuracak birazdan.

            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]); // İstanbul 





            Console.ReadLine();
        }
    }
}
