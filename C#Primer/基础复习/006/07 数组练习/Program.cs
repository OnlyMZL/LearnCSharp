using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_数组练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习1
            ////从一个整数数组中取出最大的整数，最小的整数，总和，平均值

            ////声明一个数组
            //int[] nums = { 100, 2, 3, 10, 5, 6, 7, 8, 9, 20, };
            ////声明必要的变量
            //int max = nums[0], min = nums[0], sum = 0, avg = 0;
            ////遍历数组 取得最大值，最小值，总和，平均值
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    //取最大值
            //    if (nums[i] > max)
            //    {
            //        max = nums[i];
            //    }
            //    if (nums[i] < min)
            //    {
            //        min = nums[i];
            //    }
            //    sum += nums[i];
            //    avg = sum / nums.Length;
            //}
            //Console.WriteLine("最大值是：{0}，最小值是：{1}，总和是：{2}，平均值是：{3}", max, min, sum, avg);
            //Console.ReadLine();

            #endregion

            #region  数组倒序输出
            //string[] strs = { "a", "w", "r", "c", "a", "f", "d", "e" };
            //for (int i = 0; i < strs.Length/2; i++)
            //{
            //    string temp = strs[i];
            //    strs[i] = strs[strs.Length - 1 - i];
            //    strs[strs.Length - 1 - i] = temp;
            //}
            //for (int i = 0; i < strs.Length; i++)
            //{
            //    Console.WriteLine(strs[i]);
            //}
            //Console.ReadLine();
            #endregion


        }
    }
}
