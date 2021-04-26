using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Computer"},
                new Category{CategoryId = 2, CategoryName = "Phone"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB Ram", UnitInStock= 5, UnitPrice= 10000},
                new Product{ ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "16 GB Ram", UnitInStock= 3, UnitPrice= 8000},
                new Product{ ProductId = 3, CategoryId = 1, ProductName = "HP Laptop", QuantityPerUnit = "8 GB Ram", UnitInStock= 2, UnitPrice= 6000},
                new Product{ ProductId = 4, CategoryId = 2, ProductName = "Samsung Phone", QuantityPerUnit = "4 GB Ram", UnitInStock= 15, UnitPrice= 5000},
                new Product{ ProductId = 5, CategoryId = 2, ProductName = "Apple Phone", QuantityPerUnit = "4 GB Ram", UnitInStock= 0, UnitPrice= 8000},
            };

            Console.WriteLine("Algorithm-----------------");

            foreach (var pnames in GetProducts(products))
            {
                Console.WriteLine(pnames.ProductName);
            }

            Console.WriteLine("Linq-----------------");

            //var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3 ); // Linq

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            foreach (var pnames in GetProductsLinq(products))
            {
                Console.WriteLine(pnames.ProductName);
            }
            Console.ReadLine();
        }



        static List<Product> GetProducts(List<Product> products) // Linq olmasaydı bu metodu yazmak zorunda kalıcaktık.
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
           return products.Where(p => p.UnitPrice > 1000 && p.UnitInStock > 1 && p.CategoryId == 1).ToList();
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
