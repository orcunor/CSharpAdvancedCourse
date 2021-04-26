using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();
            // customerManager.Logger = new FileLogger();
            customerManager.Logger = new SmsLogger();
            customerManager.Add();

            Console.ReadLine();

        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; } // property. Constructorla yapılabilinir aynı şey.
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Added");
        }

    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!"); ;
        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms");
        }
    }



}
