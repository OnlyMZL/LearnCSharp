using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_捕获异常
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明变量
            int num = 0;
            bool flag = true;

            //提示用户输入
            try
            {
                Console.WriteLine("请输入一个数字");
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch //抛出异常 如果有异常，给flag赋值false
            {
                Console.WriteLine("输入有误");
                flag = false;
            }
            if (flag)//如果flag为true说明没有异常发生，否则即是出现异常 不执行if内部代码
            {
                num *= 2;
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
