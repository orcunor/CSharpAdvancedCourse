using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();

            cities.Add("Ankara"); // <string> dediğimiz için string ile çalışıcağımızı belirttik. String ekleyebiliriz artık sadece.

            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            // Console.WriteLine(cities.Contains("Ankara")); // True döner. Ankara değerini arıyor.

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Orçun", LastName = "Or" });
            //customers.Add(new Customer { Id = 2, FirstName = "Deniz", LastName = "Or" });

            List<Customer> customers = new List<Customer> {
                    new Customer { Id = 1, FirstName = "Orçun", LastName = "Or" }, //0.eleman
                    new Customer { Id = 2, FirstName = "Deniz", LastName = "Or" } // 1. eleman
            };

            

            var customer2 = new Customer //2.eleman
            {
                Id = 3,
                FirstName = "Mehmet",
                LastName = "Aydın"
            };
            customers.Add(customer2);

            customers.AddRange(new Customer[2]
            {
                new Customer{Id = 4, FirstName="Görkem", LastName="Aykaç" }, //4.eleman
                new Customer{ Id = 5, FirstName = "Efecan", LastName = "Savaş"} // 5. eleman
            });

            // customers.Clear(); // Listedeki elemanları siler. eleman kalmaz

            Console.WriteLine(customers.Contains(customer2)); // True döner. new diyerek arayamazsın. new dersen yeni bir referans değer tutar asla eşleştiremezsin false döner. bir değere atıp araman gerekir. customer2 gibi.

            var index = customers.IndexOf(customer2); // customer2 nin kaçıncı sırada olduğunu bulucak
            Console.WriteLine("Index : {0}",index); // 2

            var index2 = customers.LastIndexOf(customer2); // customer2 başka olmadığı için aynı sonucu verir. Sadece aramaya sondan başladı.
            Console.WriteLine("Index : {0}",index2); // 2

            customers.Insert(0, customer2); // İnsert istenilen index'e ekler customer2 yi. Customer2 ilk eleman oldu.Diğerleri kaydı. Add sona ekliyor insert istenilen indexe ekleyebilir.

            customers.Remove(customer2); // bulduğu ilk değeri siler. customer2. Bulamazsa listede hiçbir şey yapmaz.
            customers.RemoveAll(c => c.FirstName == "Orçun"); // Predicate delegate. İsmi Orçun olanı sil. c random keyword istediğini yazabilirsin.


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count; // Liste eleman sayısını verir.



            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);
            list.Add(300);
            list.Add(400);

            // array of 4 elements
            int[] arr = new int[4];
            arr[0] = 500;
            arr[1] = 600;
            arr[2] = 700;
            arr[3] = 800;

            list.AddRange(arr);

            foreach (int val in list)
            {
                Console.WriteLine(val);
            }
            

            //ArrayList();
            Console.ReadLine();

        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList(); // her türlü değer type ' ı içinde arındırabilir. int,strnig,char vb... Tip güvenli değildir. Tip güvenliği için collections kullanırız.
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İzmir");


            //Console.WriteLine(cities[2]);
            cities.Add(1);
            cities.Add('A');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
