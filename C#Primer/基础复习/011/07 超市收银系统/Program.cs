using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_超市收银系统
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.AskBuying();
            Console.ReadKey();
        }
    }
}
