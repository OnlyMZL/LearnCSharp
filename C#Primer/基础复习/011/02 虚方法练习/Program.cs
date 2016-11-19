using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_虚方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //经理十一点打卡  员工九点打卡 程序员不打卡
            Stark s1 = new Stark();
            Manager m1 = new Manager();
            Programmer p1 = new Programmer();
            Stark[] starks = { s1, m1, p1 };
            foreach (var item in starks)
            {
                item.DaKa();
            }
            Console.ReadKey();
        }
    }
}
