using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Anonymous Method
namespace InternshipDelegates3
{
    public delegate void Print(int value);

    class Program
    {
        static void Main(string[] args)
        {
            Print print = delegate (int val) {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);
        }
    }
}
