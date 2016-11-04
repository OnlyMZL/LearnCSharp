using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_for循环正序和倒序输出
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-10正序输出

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }
            Console.Read();

            //10-1输出

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
