using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            /**********79**************
             用方法来实现：
            有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },
            请输出最长的字符串。
             *************************/

            //string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string str = GetLongest(names);
            //Console.WriteLine(str);
            //Console.ReadLine();



            /*****************************80**********************
             80、用方法来实现：请计算出一个整型数组的平均值。
             **********************************************************/

            //int[] nums = { 2,4};
            //int avg=GetAvg(nums);
            //Console.WriteLine(avg);
            //Console.ReadKey();


            /***************************81****************************
             * 81、写一个方法，用来判断用户输入的数字是不是质数 
             *     再写一个方法 要求用户只能输入数字 输入有误就一直让用户输入数字
             * **********************************/
            Console.WriteLine("请输入一个整数");
            bool b = IsPrimeNumber(Console.ReadLine());
            Console.WriteLine(b);
            Console.ReadKey();
        }




        /// <summary>
        /// 判断一个数是不是质数
        /// </summary>
        /// <param name="strnum">用户输入的内容</param>
        public static bool IsPrimeNumber(string strnum)
        {
            bool b = true;
            int num = GetIntNum(strnum);
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    b = false;
                    return b;
                }
            }
            return b;
        }



        /// <summary>
        /// 将用户输入的内容转换为整数
        /// </summary>
        /// <param name="s">用户输入的内容</param>
        /// <returns>返回整数</returns>
        public static int GetIntNum(string s)
        {
            while (true)
            {
                try
                {
                    int num = Convert.ToInt32(s);
                    return num;
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入");
                    s = Console.ReadLine();
                }
            }
        }


        /// <summary>
        /// 计算整数数组的平均值
        /// </summary>
        /// <param name="nums">要计算的数组</param>
        /// <returns>返回平均值</returns>
        public static int GetAvg(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }



        /// <summary>
        /// 输出字符串数组中的最长字符串
        /// </summary>
        /// <param name="strs">字符串数组</param>
        /// <returns>最长字符串</returns>
        public static string GetLongest(string[] strs)
        {
            string max = strs[0];
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length > max.Length)
                {
                    max = strs[i];
                }
            }
            return max;
        }
    }
}
