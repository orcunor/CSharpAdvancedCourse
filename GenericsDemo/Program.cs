using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //DataStore<string> store = new DataStore<string>();
            //store.Data = "Hello orçun!";
            //Console.WriteLine(store.Data);

            //DataStore<int> intStore = new DataStore<int>();
            //intStore.Data = 100;
            //Console.WriteLine(intStore.Data);

            //KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
            //kvp1.Key = 100;
            //kvp1.Value = "Hundred";

            //KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
            //kvp2.Key = "IT";
            //kvp2.Value = "Information Technologoy";


            DataStore2<string> cities = new DataStore2<string>();
            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");


            DataStore2<int> empIds = new DataStore2<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);

            empIds.AddOrUpdate(3, 45);
            empIds.AddOrUpdate<int>(4, 23);
            empIds.AddOrUpdate(78);
            empIds.AddOrUpdate<string>(5, "Orçun");


            Printer printer = new Printer();
            printer.Print<int>(50);
            printer.Print<string>("orçun");
            printer.Print<bool>(true);
            printer.Print<double>(5.34);
            printer.Print(200);
            printer.Print("Hello World");

            //DataStore3<string> store = new DataStore3<string>();  where T : class kullandığımız için referans tipler için geçerli olur. <int> yapamayız hata alırız.
            //DataStore3<MyClass> store = new DataStore3<MyClass>();
            //DataStore3<IMyInterface> store = new DataStore3<IMyInterface>();
            //DataStore3<IEnumerable> store = new DataStore3<IMyInterface>();
            //DataStore3<ArrayList> store = new DataStore3<ArrayList>();


            //DataStore4<int> store = new DataStore4<int>();   where T : struct kullandığımız için sadece değer typ lar için geçerli oılur.
            //DataStore4<char> store = new DataStore4<char>();
            //DataStore4<MyStruct> store = new DataStore4<MyStruct>();




            var action = new Action<int>(ShowOnDisplay);
            action(123);

            // Action<T> ve Func<TParam, TReturn> sınıfları parametre alabilir de, almayabilir de. Yani sıfır veya daha fazla parametre alabilirler.



            // Aralarındaki fark ise, Action<T> geriye değer döndürmez iken, Func<TParam, TReturn> geriye değer döndürür.

            var func = new Func<int,double>(Calculate);
            Console.WriteLine(func(5));

            Console.ReadLine();
        }

        public static void ShowOnDisplay(int i)
        {
            Console.WriteLine(i);
        }

        public static double Calculate(int i)
        {
            return (double)i / 2;
        }
    }

    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

    class DataStore<T>
    {
        public T Data { get; set; }
    }

    class DataStore2<T>
    {
        private T[] _data = new T[10];
        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
            {
                _data[index] = item;
            }
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
            {
                return _data[index];
            }
            else
            {
                return default(T);
            }
        }

        public void AddOrUpdate(T data1, T data2)
        {

        }

        public void AddOrUpdate<U> (T data1, U data2)
        {

        }

        public void AddOrUpdate(T data)
        {

        }
    }

    class Printer
    {
        public void Print<T> (T data)
        {
            Console.WriteLine(data);
        }
    }

    class DataStore3<T> where T : class
    {
        public T Data { get; set; }
    }

    class DataStore4<T> where T: struct
    {
        public T Data { get; set; }
    }


    
}
