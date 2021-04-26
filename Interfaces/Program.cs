using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal()); // oracleservercustomerdal ' da yapabiliriz. ihtiyaca göre hangisi lazımsa onu yazabiliriz İnterface sayesinde. Bağımlılığı kaldırdık.
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Orçun",
                LastName = "Or",
                Address = "İzmir"
            };

            personManager.Add(customer);

            Student student = new Student
            {
                Id = 1,
                FirstName = "Deniz",
                LastName = "Or",
                Departmant = "Computer Sciences"
            };
            personManager.Add(student);  // Hem customer hem student gönderebiliyoruz çünkü ikisi de IPersondan alınıyor. İnheritance gibi kullanabiliyoruz.

            Worker worker = new Worker
            {
                Id = 2,
                FirstName = "Orçun",
                LastName = "Or",
                Departmant = "Software Development"
            };

            personManager.Add(worker);
        }
    }
    interface IPerson // Soyut nesne. Interfaceler newlenemez. class nesneleri türetebiliriz IPerson tipinde.
    {
         int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson // Somut nesne. IPersonda tanımlanmış her şeyi burada görebiliriz. İnterfacede tanımlananlar classlarda karşılığını yazmak zorundayız.id,firstname,lastname.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson // Somut nesne. IPersonda tanımlanmış her şeyi burada görebiliriz. İnterfacede tanımlananlar classlarda karşılığını yazmak zorundayız. id,firstname,lastname
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public string Departmant { get; set; }
    }

    class PersonManager : IPerson
    {
        public void Add(IPerson person) 
        {
            Console.WriteLine(person.FirstName);
        }
        public int Id { get; set; }
        public string FirstName { get; set ; }
        public string LastName { get ; set ; }
    }
}
