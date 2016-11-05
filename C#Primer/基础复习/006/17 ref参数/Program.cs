using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //用方法来交换两个参数的值
            int n1 = 9;
            int n2 = 20;
            ExchangePara(ref n1,ref n2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.ReadLine();
        }

        /// <summary>
        /// 交换两个变量的值，
        /// </summary>
        /// <param name="n1">第一个变量</param>
        /// <param name="n2">第二个变量</param>
        public static void ExchangePara(ref int n1, ref int n2)
        {
            n1 = n1 - n2;
            n2 = n1 + n2;
            n1 = n2 - n1;
        }
    }
}
