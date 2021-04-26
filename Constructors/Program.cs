using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager(10);
            //customerManager.List();

            Product product = new Product { Id = 1, ProductName = "Laptop" };
            Product product1 = new Product(2, "Desktop"); // instance oluşturma newlemek.

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger()); // new DatabaseLogger ' da kullanabiliriz. logger'a constructora parametre olarak verip nereye loglayacağımızı seçebilirz.
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;



            Utilities.Validate();

            Manager.DoSomething(); // Static olduğu için direkt olarak class üzerinden çağırabiliriz.
            Manager manager = new Manager();
            manager.DoSomething2(); // Method static olmadığı için instance üzerinden çağırabiliriz. new'lememiz gerekir. class static olmaması şartıyla
                                    // class static olduğu zaman büün metotların static olması gerekir.

            // singleton design pattern bak.


            Console.ReadLine();
        }
    }

    class CustomerManager
    {

        public int Id { get; set; } // prop tab tab
        private int _count = 15; // private field _ ile başlatılır. default 15 verdim. Parametre verilmezse 15 gelicek. Constroctor overload yaptık

        public CustomerManager(int count) // ctor tab tab  constructor method. Count'ı private _count'a atadık.
        {
            _count = count;
        }
        public CustomerManager() // parametresiz constructor.
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items",_count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product

    {

        public Product()
        {

        }

        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database"); 
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File!");
        }
    }

    class EmployeeManager
    {
        ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity); // productManager newledik _entity parametresi "Product" olarak gönderdik. Output is Product message
        }

    }


    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity) // base sınıf için kullanıyoır. Base sınıfa parametre göndderiyor.
        {

        }
        public void Add()
        {
            Console.WriteLine("Added!!!");
            Message();
        }
    }

    static class Teacher // static için her yerde aynıdır. Her yerde ulaşabiliriz. Teacher.Number = 10; şeklinde kullanılır. Ortak kullanılan nesneler. Biri değiştiğinde diğer içinde değişmesini istediğiiz değerler için static tanımlanır.
                         
    {
        public static int Number { get; set; } // static ise class proplar da static olmalı

    }

    static class Utilities
    {
        static Utilities() 
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done.");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }
        public void DoSomething2 ()
        {
            Console.WriteLine("Done 2");
        }
    }

}
