using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipDelegates5
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> print = (x) => Console.WriteLine("Value: {0}", x);

            Func<int, int, int> sum = (x, y) => {
                Console.WriteLine("Lambda expression");
                return x + y;
            };

            print(100);
            sum(4, 6);
        }
    }
}
