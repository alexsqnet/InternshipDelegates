using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Func Delegate with Lambda Expression
namespace InternshipDelegates8
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> getRandomNumber = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber());
        }
    }
}
