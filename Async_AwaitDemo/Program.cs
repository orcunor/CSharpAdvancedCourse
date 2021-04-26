using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_AwaitDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("-- coffee is ready");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggsTask)
                {
                    Console.WriteLine("-- eggs are ready");
                }
                else if (finishedTask == baconTask)
                {
                    Console.WriteLine("-- bacon is ready");
                }
                else if (finishedTask == toastTask)
                {
                    Console.WriteLine("-- toast is ready");
                }
                breakfastTasks.Remove(finishedTask);
            }

            Juice oj = PourOJ();
            Console.WriteLine("-- oj is ready");
            Console.WriteLine("---- Breakfast is ready!");
            Console.ReadLine();
        }

        /* Kahvaltı hazırlama örneğinde; FryEggsAsync() -yumurta pişirme- , FryBaconAsync() -pastırma kızartma-, ToastBreadAsync() -ekmek kızartma- ve MakeToastWithButterAndJamAsync() -kızaran ekmeklere yağ ve reçel sürme- metotları async olarak çalıştırılmıştır.
         * Çünkü bu metotlarda; bazı işlemlerin tamamlanması için beklememiz gereken süreler mevcuttur.
           Örneğin; yumurta pişireceğimiz tavayı ocağa koyduktan sonra o tavanın ısınması için belli bir süre geçmesi gerekmektedir, ve bu süre zarfında tavanın ısınmasıyla ilgili bizim üzerimize düşen başka bir görev yoktur.
           Çünkü tavayı ısıtma işini yapan asıl birim ocaktır. Biz de bu süreyi, boş boş durmak yerine yapılacak başka işlerde değerlendirebiliriz.

            PourCoffe() -kahve doldurma-, PourOJ() -portakal suyu doldurma-, ApplyButter() -ekmeğe yağ sürme- ve ApplyJam() -ekmeğe reçel sürme- metotları senkron kodlanmıştır.
            Çünkü bu işlemler bizzat bizim tarafımızdan gerçekleştirilmektedir. Yani bu işlemleri yaparken herhangi birşeyin tamamlanmasını beklemiyoruz.
            Örneğin; ApplyButter() metodu zaten ekmek kızardıktan sonra çalıştırılıyor. (Biz de elimize yağı alıp ekmeğe sürüyoruz.) Bu arada başka tamamlanmasını beklememiz gereken bir işlem yok.

            Tüm asenkron metotlar; birer Task nesnesine atanıp breakfastTasks isimli Task listesine ekleniyor.
            Listede var olan Task sayısının 0’dan büyük olma koşulu ile bir while döngüsü başlatılıyor.
            Döngü her döndüğünde WhenAny() metodu kullanarak tamamlanmış olan herhangi bir Task için ekrana “… is ready” çıktısı basıldıktan sonra ilgili Task listeden çıkarılıyor.
            Listede hiç Task kalmadığında da döngü sonlanıyor..


         * */

        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("# OJ: Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("# Jam: Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("# Jam: Putting butter on the toast");

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("# Toast: Putting a slice of bread in the toaster");
            }
            Console.WriteLine("# Toast: Start toasting...");
            await Task.Delay(3000);
            Console.WriteLine("# Toast: Remove toast from toaster");

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"# Bacon: putting {slices} slices of bacon in the pan");
            Console.WriteLine("# Bacon: cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("# Bacon: flipping a slice of bacon");
            }
            Console.WriteLine("# Bacon: cooking the second side of bacon...");
            await Task.Delay(3000);
            Console.WriteLine("# Bacon: Put bacon on plate");

            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("# Egg: Warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"# Egg: cracking {howMany} eggs");
            Console.WriteLine("# Egg: cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("# Egg: Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("# Coffee: Pouring coffee");
            return new Coffee();
        }
    }

    class Juice
    {
        public Juice()
        {
        }
    }

    class Toast
    {
        public Toast()
        {
        }
    }

    class Bacon
    {
        public Bacon()
        {
        }
    }

    class Egg
    {
        public Egg()
        {
        }
    }

    class Coffee
    {
    }
}
