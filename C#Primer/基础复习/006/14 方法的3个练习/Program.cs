using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_方法的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ////改写方法，  只允许用户输入yes与no
            ////输入yes就能看，输入no就不能看
            //Console.WriteLine("请输入yes或者no");
            //string str = Console.ReadLine();
            //string result = IsYesOrNo(str);
            //Console.WriteLine(result);
            //Console.ReadLine();


            //计算数组的和  调用方法
            int[] nums = { 1, 3, 4, 6, 6767 };
            int sum = GetArraySum(nums);
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        /// <summary>
        /// 计算一个整数类型数组的和
        /// </summary>
        /// <param name="arr">要计算的数组</param>
        /// <returns>数组的和</returns>
        public static int GetArraySum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }


        /// <summary>
        /// 限定用户的输入只能是yes或者no，并且返回用户输入
        /// </summary>
        /// <param name="input">获取用户输入的参数</param>
        /// <returns>返回用户输入</returns>
        public static string IsYesOrNo(string input)
        {
            while (true)
            {
                if (input == "yes" || input == "no")
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("只能输入yes或者no，请重新输入");
                    input = Console.ReadLine();
                }
            }

        }
    }
}
