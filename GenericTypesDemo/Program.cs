using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypesDemo
{
    class Program
    {
        private class ExampleClass { }
        static void Main(string[] args)
        {
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);

            GenericList<string> list2 = new GenericList<string>();
            list2.Add("Orçun");

            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass());

            List<int> sayilar = new List<int>();
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(5);
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadLine();
        }
    }

    public class GenericList<T>
    {
        public void Add(T input) { }
    }


}
