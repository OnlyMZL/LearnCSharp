using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_加加减减
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a++ + ++a * 2 + --a + a++;
            //      5    +  7*2   +  6  + 6  =31    a=7
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
