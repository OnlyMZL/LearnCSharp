using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_and_ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            int j = 34;
            Console.WriteLine("i,j的原始值是{0}和{1}", i, j);

            TestRef(ref i, ref j);
            Console.WriteLine("TestRef之后i,j的值是{0}和{1}", i, j);

            bool isZero = TestOut(i, out j);
            Console.WriteLine("TestOut之后i{0}为0，j={1}", isZero.ToString(), j);
            Console.ReadKey();
        }

        /// <summary>
        /// 交换a与b的值
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void TestRef(ref int a, ref int b)
        {
            //ref关键字有进有出,在方法内可以不为变量赋初值
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// 判断a是否为0,如果为0返回true，并将b赋值为0。否则返回false，将a的值赋给b。
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>bool值</returns>
        static bool TestOut(int a, out int b)
        {
            b = 0;  //out关键字只出不进，并要在方法内为变量赋初值。
            if (a != 0)
            {
                b = a;
                return false;
            }
            else
                return true;
        }
    }
}
