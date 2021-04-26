using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Thread thread1 = new Thread(new ThreadStart(ThreadFuncEven));
            //Thread thread2 = new Thread(new ThreadStart(ThreadFuncOdd));
            ////Threadleri başlatalım bakalım sırasına göremi yoksa paralelmi işleyecek.
            ////Sırasına göre işlenseydi önce çift sayılar, sonra tek sayılar basılmalıydı.

            //thread1.Start();
            //thread2.Start();

            //Thread t = new Thread(WriteY);
            //t.Start();


            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.WriteLine("ABA");
            //}

            Thread t = new Thread(Go);
            t.Start();
            t.Join();
            Console.WriteLine("Thread t has ended!");

            Console.ReadLine();
        }

        static void ThreadFuncEven()
        {
            for (int i = 0; i < 100; i+= 2)
            {
                //Her çift Sayı için 1 saniye bekleyelim ve sayıyı yazdıralım
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }

        }

        static void ThreadFuncOdd()
        {
            for (int i = 1; i < 100; i+= 2)
            {
                //Her tek Sayı için bir saniye bekleyelim ve sayıyı yazdırsın
                Thread.Sleep(2000);
                Console.WriteLine(i);
            }
        }


        static void WriteY()
        {
            for (int i = 0; i < 11000; i++)
            {
                Console.WriteLine("Y");
            }
        }

        static void Go()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Y");
            }
        }
    }

}
