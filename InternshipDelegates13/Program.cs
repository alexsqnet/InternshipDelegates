using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Predicate Delegate
namespace InternshipDelegates13
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpper = s => s.Equals(s.ToUpper());
            bool result = isUpper("this is a predicate");

            Console.WriteLine(result);
        }
    }
}
