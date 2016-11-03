using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要判断的年份：");
            int year = Convert.ToInt32(Console.ReadLine());
            bool b=year % 4 ==0;
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
