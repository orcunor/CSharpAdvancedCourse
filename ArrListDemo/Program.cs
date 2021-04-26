using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrListDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var arrlist = new ArrayList();
            arrlist.Add(1);
            arrlist.Add("Orçun");
            arrlist.Add(" ");
            arrlist.Add(true);
            arrlist.Add(4.5);
            arrlist.Add(null);

            var arrlist2 = new ArrayList
            {
                2,"Or", " ", false, 4.5,null
            };

            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");

            arrlist.AddRange(arrlist2); // adding arraylist in arraylist
            arrlist.AddRange(arr); // adding array in arraylist
            arrlist.AddRange(myQ); // adding Queue in arraylist

            //int firstElement = (int)arrlist[0];
            //string secondElement = (string)arrlist[1];

            var firstElement = arrlist[0];
            var secondElement = arrlist[1];

            // Upddate element

            arrlist[0] = "Steve";
            arrlist[1] = 100;

            foreach (var item in arrlist)
            {
                Console.WriteLine(item + ", ");
            }

            for (int i = 0; i < arrlist.Count; i++)
            {
                Console.WriteLine(arrlist[i] + ", ");
            }

            arrlist.Insert(1, "Second Item");

            foreach (var val in arrlist)
            {
                Console.WriteLine(val);
            }

            ArrayList arrlist1 = new ArrayList()
            {
                100,200,600
            };

            ArrayList arrlist3 = new ArrayList()
            {
                300,400,500
            };

            arrlist1.InsertRange(2, arrlist3);

            foreach (var item in arrlist1)
            {
                Console.WriteLine(item+ ", ");
            }

            arrlist1.Remove(null); //Removes first occurance of null
            arrlist1.RemoveAt(4); //Removes element at index 4
            arrlist1.RemoveRange(0, 2); //Removes two elements starting from 1st item (0 index)


            // ArrayList Methods

            // Add()/AddRange()
            // Insert()/InsertRange()
            // Remove()/RemoveRange()
            // RemoveAt()
            // Sort() Reverse()  Contains Clear CopyTo  GetRange IndexOf  ToArray


            Console.ReadLine();
        }
    }
}
