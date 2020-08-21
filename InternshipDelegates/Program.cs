using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipDelegates
{
    public delegate void Print(int value);

    class Program
    {
        static void Main(string[] args)
        {
            //Print printDel = new Print(PrintToConsole);
            Print printDel = PrintToConsole;

            printDel(2);
            // OR
            printDel.Invoke(23);

            Console.ReadLine();
        }

        static void PrintToConsole(int value) 
        {
            Console.WriteLine(value);
        }
    }
}
