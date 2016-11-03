using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            ////练习，变成实现计算几天（如46）是几周零几天
            //int i;
            //Console.WriteLine("请输入天数：");
            //i = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0}天是{1}周零{2}天",i,i/7,i%7);
            //Console.ReadLine();


            //编程实现107653秒是几天几小时几分钟几秒
            int secs = 107653;
            int sec = secs % 60;
            int days = secs / (60 * 60 * 24);
            int hours = secs / (60 * 60) % 24;
            int mins = secs / 60 % 60;
            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒",secs,days,hours,mins,sec);
            Console.ReadKey();
        }
    }
}
