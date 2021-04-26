using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> dictionary = new Dictionary<string, string>(); // Key, Value çalışır. typelarını belirtiriz. <string,string>
            dictionary.Add("book", "kitap");
            dictionary.Add("computer", "Bilgisayar");
            dictionary.Add("table", "masa");


            Console.WriteLine(dictionary["computer"]); // Bilgisayar

            foreach (var item in dictionary)
            {
                Console.WriteLine(item); // item.Key   item.Value ulaşabiliriz.
            }

            dictionary.Count();

            dictionary.ContainsKey("glass"); // false döner glass key yok çünkü dictionaryde.

            dictionary.ContainsKey("table"); // true döner.

            dictionary.ContainsValue("masa"); // true döner. 




            Console.ReadLine();
        }
    }
}
