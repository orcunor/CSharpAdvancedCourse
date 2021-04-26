using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer { Id = 1, FirstName = "Orçun", LastName = "Or", Age = 24 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

            Console.ReadLine();

        }
    }

    [ToTable("Customers")] // Customer class i databasedeki Customers tablosuna denk gelir demek.
    [ToTable("TblCustomers")] // Customer class i bazı projelerde Customers tablosuna denk gelir demek. Customers ve TblCustomers olarak ara demek. AllowMultiple = true yapmak lazım.
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty] // FirstName property si girilmek zorunda olsun boş geçilmesin. kullanıcı vermek zorunda.
        public string FirstName { get; set; }
        [RequiredProperty] // LastName property si girilmek zorunda olsun boş geçilmesin. kullanıcı vermek zorunda.
        public string LastName { get; set; }
        [RequiredProperty] // Age property si girilmek zorunda olsun boş geçilmesin. kullanıcı vermek zorunda.
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("dont use Add, instead use AddNew Method")] // hazır attribute. Add eskide kaldı addi kullanma yerine AddNew methodunu kullan dedik.
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} ",customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)] // .All dersek bu attributeyi heryerde kullanabilirsin demek .Class dersek mesela bu attribute ı sadece Classlarda kullanabilrisin.Burda property de kullanıyoruz.
    class RequiredPropertyAttribute: Attribute
    {

    }


    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)] // AllowMultiple = true demek aynı şey için birden fazla attribute kullanmaya izin verir.
    class ToTableAttribute : Attribute // Attribute sınıfından inheritance etmek zorundayız.
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

}
