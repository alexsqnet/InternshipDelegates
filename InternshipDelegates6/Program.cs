using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Func delegate
namespace InternshipDelegates6
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;

            int result = add(10, 10);

            Console.WriteLine(result);
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
