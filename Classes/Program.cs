using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.FirstName = "Orçun"; // set bloğu çalışır.
            customer.LastName = "Or";
            customer.Id = 1;

            Customer customer1 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName= "Barış", LastName = "Gündoğdu"
            };

            Console.WriteLine(customer1.FirstName); // get bloğu çalışır burda 

            Console.ReadLine();
        }
    }
}

   
    
