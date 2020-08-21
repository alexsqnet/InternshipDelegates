using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipDelegates2
{
    public delegate void Print(int value);

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            //Create delegate instances
            Print printDel1 = new Print(PrintToConsole);
            Print printDel2 = myClass.PrintToConsole;

            //Invoke methods
            printDel1(24);
            printDel2.Invoke(25);

            Console.ReadLine();
        }

        static void PrintToConsole(int value)
        {
            Console.WriteLine(value);
        }
    }

    class MyClass
    {
        public void PrintToConsole(int value)
        {
            Console.WriteLine(value);
        }
    }
}
