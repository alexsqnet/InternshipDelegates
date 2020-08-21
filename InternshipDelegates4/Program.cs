using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipDelegates4
{
    public delegate void Print(int value);
    public delegate int Sum(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Print print = x => Console.WriteLine(" Value: {0}", x);

            Sum sum = (x,y) => {
                                    Console.WriteLine("Lambda expression");
                                    return x + y; 
                               };

            print(100);
            sum(4, 6);
        }
    }
}

