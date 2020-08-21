using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Action Delegate with Lambda Expression
namespace InternshipDelegates12
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> printActionDel = i => Console.WriteLine(i);

            printActionDel(10);
        }
    }
}
