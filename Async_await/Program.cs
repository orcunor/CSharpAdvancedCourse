using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_await
{
    class Program
    {


        static void Main(string[] args)
        {
            //    Console.WriteLine("İşlemler başlıyor");
            //    Task.Run(() => BirinciIslem()); // İkinci işlem birinci işlemi beklemedi en son birinci işlem çalıştı. 
            //    //  Task.Run() metodu ile birlikte; yeni bir Thread açılır, ve işlem bu Thread üzerinde çalışmaya başlar..
            //    // Task.Run(() => BirinciIslem()); çalıştırılır. Programımızın asenkron çalıştığı nokta tam da burasıdır.
            //    //  Task.Run() metodunun çağrılmasıyla birlikte; BirinciIslem() metodunu çağıracak olan yeni bir görev (Task) kuyruğa eklenir.
            //    //  Eğer, CPU‘nun yazdığımız program için ayırdığı iş parçacığı havuzunda (Thread Pool) boşta Thread var ise; kuyruğa eklenen görev hemen boştaki Thread üzerinde çalışmaya başlar.
            //    //  Eğer, Threadpool‘da boş bir Thread yok ise, işi biten Thread‘ler üzerinde kuyruktaki Task‘ler çalıştırılmaya başlanır.
            //    //  Böylelikle; BirinciIslem() metodu, Main() metodunun çalıştığı Thread‘den ayrılmış olur ve yoluna asenkron bir şekilde devam eder.
            //    IkinciIslem();
            //    Console.WriteLine("İşlemler tamamlandı.");

            //    // burdan sonra Main() metodunu çağıran Thread‘deki işlemler bittiği için artık bu Thread boşa çıkmıştır.
            //    // Artık kuyrukta bekleyen Task‘i çalıştırmaya başlayabilir.
            //    // (ki ekran çıktısına bakacak olursak, Main() metodunu çağıran Thread boşa çıkınca hemen BirinciIslem() metodunu çağıracak olan Task devreye alınmış ve BirinciIslem() metodu çağırılmış görünüyor.)

            Console.WriteLine("İşlemler başlıyor.");
            BirinciIslem();
            IkinciIslem();
            Console.WriteLine("İşlemler tamamlandı.");
            // Output is:
            // Islemler basliyor.
            // Birinci islem basladi.
            // Ikinci islem basladi.
            // Ikinci islem bitti.
            // Islemler tamamlandi.
            // Birinci islem 2 sn bekleme uygulandi.
            // Birinci islem bitti.

            /* Her iki örnekte de BirinciIslem() metodunu (farklı yöntemlerle) asenkron olarak çalıştırdık. 
             * Fakat önceki örnekteki BirinciIslem() metodu “İşlemler tamamlandı.” yazısından sonra çalışmaya başladı.
             * Önceki örnekte meydana gelen bu gecikmenin sebebi; yeni bir Thread açılıp, işlemlerin yeni Thread‘e taşınması için gerçekleşen işlemlerden kaynaklanmaktadır. */

            /*  Thread.Sleep() metodu senkron olarak çalışır ve çalıştığı Thread‘i verilen süre kadar bekletir.
                Eğer Thread.Sleep() kullanmış olsaydık; async hale getirdiğimiz BirinciIslem() metodu, halen aynı Main() metod ile Thread üzerinde çalıştığı için bekletme işlemi tüm programa uygulanmış olacaktı.
                Fakat biz bekletme işlemini sadece BirinciIslem() metodu içerisinde yapmak istediğimiz için yine async bir metod olan Task.Delay() kullandık.
                await anahtar kelimesini de bu metodun önüne koyarak, yapılan bekletme işlemi tamamlanana kadar BirinciIslem() metodunun kilitlenmesini; yani async olan Task.Delay() metodunun çalışmasının tamamlanmasını sağladık.  */



            /* Eğer yapacağınız işlem; I/O-Bound(Web veri çekme falan cpu olmayan işlemler) türündeyse, bu işlemi async/await kullanarak asenkron bir şekilde gerçekleştirmelisiniz. 
             * Bu işlem süresince CPU herhangi bir yük altında kalmadığı için; ilgili Thread üzerindeki diğer işlemler çalıştırılmaya devam edebilir.
               Fakat yapılacak işlem; CPU-Bound türündeyse, bu işlemi Task.Run() kullanarak gerçekleştirmeliyiz. Sonuçta yapılacak işlem CPU tarafından gerçekleştirilecektir.
               Yani bu yükten kaçışımız yok, dolayısıyla bu işlemi ayrı bir Thread‘de gerçekleştirmek CPU‘nun daha verimli bir şekilde kullanılmasını sağlayacaktır. */

            /* Async metotların donüş tipi Task / Task<T> veya ValueTask / ValueTask<T> olmak zorundadır. 
             * Eğer async bir metot tamamlandığında herhangi bir değer döndürmemiz gerekmiyorsa (yani –senkron olarak çalıştığı durumda- void bir metot ise) dönüş tipini Task veya ValueTask olarak belirleyebiliriz.
             * Fakat, işlem tamamlandığında bir değer döndürmemiz gerekiyorsa dönüş tipini Task<T> veya ValueTask<T> olarak belirlemeliyiz.
             * (Örneğin, async bir metot int değeri dönecekse Task<int> / ValueTask<int> şeklinde olmalı) */

            /* Task sınıfı içerisinde bulunan WhenAny() metodu; içerisine parametre olarak geçilen Task’lerden tamamlanmış olan herhangi bir Task‘i size geri döner.
                WhenAll() metodu ise; parametre olan geçilen Task‘ler içerisinde tamamlanmış olan tüm Task‘leri liste olarak (IEnumerable<Task> tipinde) size geri döner.
             */





            Console.ReadLine();
            //}

            //public static void BirinciIslem()
            //{
            //    Console.WriteLine("Birinci İşlem başlatıldı.");
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Birinci işlem 2 sn bekleme uygulandı.");
            //    Console.WriteLine("Birinci işlem bitti.");
            //}

            //public static void IkinciIslem()
            //{
            //    Console.WriteLine("İkinci işlem başlatıldı.");
            //    Console.WriteLine("İkinci işlem bitti.");
            //}

        }

        public async static Task BirinciIslem()
        {
            Console.WriteLine("Birinci işlem başladı.");
            await Task.Delay(2000);
            Console.WriteLine("Birinci işlem 2 sn bekleme uygulandı.");
            Console.WriteLine("Birinci işlem bitti.");
        }

        public static void IkinciIslem()
        {
            Console.WriteLine("İkinci işlem başladı.");
            Console.WriteLine("İkinci işlem bitti.");
        }

    }
}
