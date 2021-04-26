using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate(); // elçilik.gövdesi yok. bişi döndürmüo aslına void döndürüyo. kullanılan methodların da void olması lazım.
    public delegate void MyDelegate2(string n);
    public delegate int MyDelegate3(int number1, int number2); // int parametre istiyor. integer dönüyor
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();


            MyDelegate myDelegate = customerManager.SendMessage; // Özel elçilik SendMessageyi taşıyacak
            myDelegate += customerManager.ShowAlert; // ikiside çalışıcak ikisini de yazdırıcak delegate.

            myDelegate -= customerManager.SendMessage; // SendMessage yi geri al yazdırma artık bunu dedik. çıkardık bunu be carefull yazıcak sadece.

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            
            var sonuc = myDelegate3(2, 3); // return eden typelarda += yaparken en son verdiğimiz delegateyi döndürür ikisini de alt alta yazdırmaz öyle.
            Console.WriteLine(sonuc);

            myDelegate2("Hellooooo"); // 2 operasyon içinde helloooo yu gönderiyoruz..
            myDelegate();




            Console.ReadLine();


        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
