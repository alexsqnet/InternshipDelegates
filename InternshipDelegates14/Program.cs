using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Multicast Delegates
namespace InternshipDelegates14
{
    delegate void CustomDel(string s);

    class Program
    {
        // Define two methods that have the same signature as CustomDel.
        static void Hello(string s)
        {
            Console.WriteLine($"  Hello, {s}!");
        }

        static void Goodbye(string s)
        {
            Console.WriteLine($"  Goodbye, {s}!");
        }

        static void Main()
        {
            // Declare instances of the custom delegate.
            CustomDel hiDel, byeDel, multiDel, multiMinusHiDel;

            hiDel = Hello;

            byeDel = Goodbye;

            // The two delegates, hiDel and byeDel, are combined to
            // form multiDel.
            multiDel = hiDel + byeDel;

            // Remove hiDel from the multicast delegate
            multiMinusHiDel = multiDel - hiDel;

            Console.WriteLine("Invoking delegate multiDel:");
            multiDel("C");
            Console.WriteLine("Invoking delegate multiMinusHiDel:");
            multiMinusHiDel("D");
        }
    }
}
