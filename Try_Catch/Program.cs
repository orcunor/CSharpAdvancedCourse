using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryCatch();

            //TryCatch_Not();


            //try
            //{
            //    Bolme();
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0 a bölme hatasi.");
            //}
            //catch (ArithmeticException)
            //{
            //    Console.WriteLine("Aritmetik Hata");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hata:\n");
            //    Console.WriteLine(ex.Message);
            //}


            try
            {
                Console.WriteLine("Notu giriniz.");
                byte not = Convert.ToByte(Console.ReadLine());

                if (not < 45)
                {
                    Console.WriteLine("Kaldınız.");
                }else if (not >= 45 && not <= 100)
                {
                    Console.WriteLine("Geçtiniz.");
                }else if (not > 100 && not < 256)
                {
                    throw new OverflowException();
                }
               
            }
            catch (Exception ex)
            {

                if (ex is OverflowException)
                {
                    ex.Data["stringInfo"] = "100 den büyük bir değer girdiniz.";
                    ex.Data["Time"] = DateTime.Now;
                }
                foreach (DictionaryEntry bilgi in ex.Data)
                {
                    Console.WriteLine(bilgi.Value.ToString());
                }
            }
















            Console.ReadLine();
        }

        private static void Bolme()
        {
            int number, bolen, sonuc;
            Console.WriteLine("Sayı giriniz: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bölen sayiyi giriniz: ");
            bolen = Convert.ToInt32(Console.ReadLine());
            sonuc = number / bolen;
            Console.WriteLine("Sonuc = {0}", sonuc);
        }

        private static void TryCatch_Not()
        {
            try
            {
                byte not;
                not = Convert.ToByte("256");


                if (not < 45 &&  not >= 0)
                {
                    Console.WriteLine("Kaldınız.");
                }
                else if (not >= 45 && not <= 100)
                {
                    Console.WriteLine("Geçtiniz.");
                }
                else if (not < 0 || not > 100)
                {
                    try
                    {
                        throw new OverflowException("Geçerli bir sayı girin.");
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Öngörülen sınırlar dışında bir değer girdiniz.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Rakam girmelisiniz.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.InnerException);
            }
        }

        private static void TryCatch()
        {
            try
            {
                int num1 = 0;
                int result = 10 / num1;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
    }

    
}
