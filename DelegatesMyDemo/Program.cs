using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesMyDemo
{
    public static void ConsolePrint(int i)
    {
        Console.WriteLine(i);
    }

    public delegate void FirstStudentNumberDelegate();
    public delegate int StudentNumberSumDelegate(int a, int b);
    public delegate void StudentHiDelegate(string n);
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            FirstStudentNumberDelegate firstStudentNumberDelegate = student.FirstStudentName;
            firstStudentNumberDelegate();

            StudentNumberSumDelegate studentNumberSumDelegate = student.StudentNumberSum;
            var result = studentNumberSumDelegate(34, 56);
            Console.WriteLine(result);

            StudentHiDelegate studentHiDelegate = student.StudentHi;
            studentHiDelegate("Naber student");

            Console.ReadLine();

            //Action<int> printActionDel = ConsolePrint;

            ////Or
            ////Action<int> printActionDel = new Action<int>(ConsolePrint);

            //printActionDel(10);
            //Print prnt = ConsolePrint;
            //prnt(10);

        }
        
    }
    
    public class Student
    {
        public void StudentHi(string message)
        {
            Console.WriteLine(message);
        }

        public int StudentNumberSum(int a, int b)
        {
            return a + b;
        }

        public void FirstStudentName()
        {
            Console.WriteLine("Orçun");
        }

    }
}
