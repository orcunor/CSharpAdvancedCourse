using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara","İzmir","Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            List<Customer> result2 = utilities.BuildList<Customer>(new Customer {FirstName = "Orçun" }, new Customer { FirstName = "Deniz" });

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }







            Console.ReadLine();
        }

        
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T [] items)
        {
            return new List<T>(items);
        }
    }

    class Product : IEntity // veritabanı nesnesisin demek. IEntity i ben oluşturdum
    {

    }

    interface IProductDal:IRepository<Product>
    {
        List<Product> GetAll();
        Product Get(int id);

        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);

    }
    class Customer : IEntity
    {
        public string FirstName { get; set; }
    }

    interface ICustomerDal:IRepository<Customer>

    {
        

    }

    interface IEntity
    {

    }

    interface IStudentDal : IRepository<Student>
    {

    }

    class Student : IEntity
    {

    }

    

    interface IRepository<T> where T : class, IEntity, new() // T typedan gelir. T yerine class yazmak referans tip olmak zorunda demek. String , class , interface yazılabilinir.
                                             // where T: class , IEntity (bundan implement edilenler yazılsın sadece), new()  newlenebilenler yazılabilsin sadece demek.
                                             // where T: struct  değer tipler yazılabilsin demek. int,bool,long,double vs..
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

    class StudentDal
    {


    }
}
