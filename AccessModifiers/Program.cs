using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }

    public class Customer // AccessModifiersDemo 'dan bu sınıfa erişmek için public yaptım.
    {
       private int Id { get; set; } // tanımlandığı blok içerisinde geçerli sadece ve sadece Inheritance yapsan bile o sınıfta kullanamazsın.
       // protected int Id { get; set; } // private gibi davranır. Tek farkı inheritance edilen sınıflarda da kullanılır.


        public void Save()
        {
            
        }
    }

    class Student : Customer
    {
         
        public void Save()
        {

        }
    }

    internal class Course // class'ın defaultu internaldır. Bağlı olduğu projede referans kullanmadan erişebiliriz.
    {
        public string Name { get; set; }

        private class NestedClass  // iç içe class dışında bir class private veya protected olamaz. İnternal veya public olabilir.
        {

        }


    }
}
