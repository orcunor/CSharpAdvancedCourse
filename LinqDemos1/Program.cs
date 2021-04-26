using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemos1
{
    class Program
    {
        static void Main(string[] args)
        {

            var values = new int[] { 0,1,2,3,4,7,34,9,13,12,22,43,55,6};

            var filtered =
                from value in values
                where value < 4
                select value;

            var sorted =
                from value in values
                orderby value
                select value;

            var sortFilteredResults =
                from value in filtered
                orderby value descending
                select value;


            // Console.WriteLine(sorted.GetType());
            Console.WriteLine("\nOriginal array filtered");
            foreach (var element in filtered)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nOriginal array, sorted:");
            foreach (var element in sorted)
            {
                Console.WriteLine(element);
            }

            foreach (var element in sortFilteredResults)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nSortFilteredResult");
            foreach (var element in sortFilteredResults)
            {
                Console.WriteLine(element);
            }



            Console.ReadKey();
        }
    }
}
