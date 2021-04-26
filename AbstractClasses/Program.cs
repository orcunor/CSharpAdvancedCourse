using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle(); // İnterface gibi abstract sınıfı newleyemiyoruz.
            database.Add();
            database.Delete();

            Database database1 = new SqlServer();
            database1.Add();
            database1.Delete();

            Console.ReadLine();

        }
    }
    // Abstract class da methodlardan biri her yerde aynı, bazı methodlar her class için farklı çalışacaksa abstract kullanıyoruz. Katiyen new'leyemeyiz abstract classları.
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete(); // tamamlanmamış method. içi dolu olmayan virtual method. Herksin ayrı ayrı implement etmesi gerekir.
        
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
