using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Orçun";
            string student2 = "Mete";
            string student3 = "Barış";

            string[] students = { "Orçun", "Mete", "Barış" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[4, 3]
            {
                {"İstanbul","İzmit","Balıkesir" }, // 4 rows , 3 fields.  1.row
                {"Ankara","Konya","Kırıkkale"}, // 2.row 
                {"Antalya","Adana","Mersin"}, // 3.row
                {"Rize","Trabzon","Samsun"} // 4.row
               
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++) // GetUpperBound 0. dimension 4
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++) // GetUpperBound 1. dimension 3
                {
                    Console.WriteLine(regions[i,j]);
                }
            }
            



            Console.ReadLine();

        }
    }
}
