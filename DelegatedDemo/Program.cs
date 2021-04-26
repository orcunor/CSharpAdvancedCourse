using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatedDemo
{
    public delegate int MyDelegate(int a, int b);
    public delegate void MyDelegate2(string n);
    public delegate void MyDelegate3();

    class Program
    {
        static void Main(string[] args)
        {
            //Deneme1();

            //Matematik matematik = new Matematik();
            //MyDelegate myDelegate = matematik.Toplama;

            //myDelegate = matematik.Toplama;
            //myDelegate += matematik.Cikarma;
            //var sonuc = myDelegate(59, 23);

            //Console.WriteLine(sonuc);

            SayHi sayHi = new SayHi();
            MyDelegate2 myDelegate2 = sayHi.SendAlert;
            myDelegate2 += sayHi.SendMessage;
            myDelegate2("Selaammm");


            MyDelegate3 myDelegate3 = sayHi.SendMessage2;
            myDelegate3 += sayHi.SendAlert2;
            myDelegate3();









            Console.ReadLine();


            
            

        }

        private static void Deneme1()
        {
            KomutYapisi[] komutlar = new KomutYapisi[4];
            komutlar[0].Komut = "Dir";
            komutlar[0].komutMetodu = new KomutMetodu(Dir);

            komutlar[1].Komut = "Edit";
            komutlar[1].komutMetodu = new KomutMetodu(Edit);

            komutlar[2].Komut = "Copy";
            komutlar[2].komutMetodu = new KomutMetodu(Copy);

            komutlar[3].Komut = "Rename";
            komutlar[3].komutMetodu = new KomutMetodu(Rename);

            string GirilenKomut;

            while (true)
            {
                Console.WriteLine("DOS :> ");
                GirilenKomut = Console.ReadLine();

                for (int i = 0; i < komutlar.Length; i++)
                {
                    if (GirilenKomut == komutlar[i].Komut)
                    {
                        komutlar[i].komutMetodu();
                    }
                }
            }
        }

        public delegate void KomutMetodu();

        public struct KomutYapisi
        {
            public KomutMetodu komutMetodu;
            public string Komut;
        }

        public static void Dir()
        {
            Console.WriteLine("Dir metodu çalıştı.");
        }
        public static void Edit()
        {
            Console.WriteLine("Edit metodu çalıştı.");
        }
        public static void Copy()
        {
            Console.WriteLine("Copy metodu çalıştı.");
        }
        public static void Rename()
        {
            Console.WriteLine("Rename metodu çalıştı.");
        }
    }

    public class Matematik
    {
       public int Toplama (int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Cikarma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
        public int Carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Bolme(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }

    }

    public class SayHi
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void SendAlert(string message)
        {
            Console.WriteLine(message);
        }

        public void SendMessage2()
        {
            Console.WriteLine("message");
        }
        public void SendAlert2()
        {
            Console.WriteLine("Alert");
        }
    }
}
