using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            //TryCatch();

            Func<int,int,int> add = Topla;
            Console.WriteLine(add(5,7));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100); // 1 ile 100 arasında random sayı üret.
            };

            
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100); // boş parametreye action yazıyoruz lambda expression
            Console.WriteLine(getRandomNumber2); // Func actionla aynı tek farkı bir değeri return ediyor.
            Thread.Sleep(1000);

            Console.WriteLine(getRandomNumber());
            //Console.WriteLine(Topla(2, 3));


            Console.ReadLine();


        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Orçun", "Deniz", "Ahmet" };

            if (!students.Contains("Salih")) // Eğer listede salih yoksa hata fırlat.
            {

                throw new RecordNotFoundException("Record not found."); 
            }
            else
            {
                Console.WriteLine("Record found.");
            }
        }

        private static void ExceptionIntro()
        {
            try // Şu kodu yapmayı dene
            {
                string[] students = new string[3] { "Orçun", "Deniz", "Görkem" };
                students[3] = "Ahmet";

            }
            catch (IndexOutOfRangeException exception) // aldığın hatanın türü buysa bu bloğa gir.
            {
                Console.WriteLine(exception.Message);

            }
            catch (Exception exception) // Hata varsa bu bloğa gir.
            {

                Console.WriteLine(exception.Message);
            }
        }
    }
}
