using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.City = "Çanakkale";

            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "Orçun"
                },new Student
                { 
                    FirstName = "Derin"
                },
                new Person
                {
                    FirstName = "Ali"
                }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName); // Orçun, Derin, Ali 
            }

            Console.ReadLine();



        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Person2
    {

    }

    class Customer : Person // Kalıtım. İnheritance .  Customer Person classından miras almıştır. Person classı Customer classının babasıdır.
    {
        public string City { get; set; }
    }

    class Student : Person // Classlar sadece bir classdan inheritance alır. Fakat birden fazla implementasyon yapabiliriz.(interface)
    {
        public string Departmant { get; set; }
    }


}
