using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionFuncDemos
{
    class Program
    {
        static void Main(string[] args)
        {

            //var action = new Action<int>(EkrandaGoster);
            //action(123);

            //var func = new Func<int, double>(Hesapla);
            //Console.WriteLine(func(5));


            var action1 = new Action<int, bool>(EkrandaGoster);
            action1(123124, true);

            var func1 = new Func<int, float, string>(Hesapla);
            Console.WriteLine(func1(5,3.5f));

            Console.ReadLine();
        }

        public static void EkrandaGoster(int i, bool a)
        {
            Console.WriteLine(i);
            Console.WriteLine(a);
        }

        public static string Hesapla(int i, float y)
        {
            var x = (i / 2) + (y / 2);
            return x.ToString() ;
        }
    }
}
