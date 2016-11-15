using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_集合的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //将一个数组中的奇数放到一个集合中，再将偶数放到另一个集合中
            //最终将两个集合合并为一个集合，并且奇数显示再左边，偶数显示在右边
            #region
            //声明一个整数数组
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //List<int> oddNums = new List<int>();  //声明一个集合存储 奇数
            //List<int> evenNums = new List<int>();  //声明一个集合存储 偶数
            ////向两个集合中分别填充 nums中的奇数和偶数
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 != 0)
            //    {
            //        oddNums.Add(nums[i]);
            //    }
            //    else
            //    {
            //        evenNums.Add(nums[i]);
            //    }
            //}
            ////声明一个字典集合 存储 oddNums、evenNums 中的数值
            //Dictionary<int, int> col = new Dictionary<int, int>();
            ////添加键值对
            //for (int i = 0; i < oddNums.Count; i++)
            //{
            //    col.Add(oddNums[i], evenNums[i]);
            //}
            ////第一种遍历方法
            //foreach (int item in col.Keys)
            //{
            //    Console.WriteLine("{0}---{1}", item, col[item]);
            //}
            ////第二种遍历方法
            //foreach (KeyValuePair<int, int> item in col)
            //{
            //    Console.WriteLine("{0}---{1}", item.Key,item.Value);
            //}
            //Console.ReadKey();
            #endregion


            //提示用户输入一个字符串，通过foreach循环将用户输入的字符串赋值给一个字符数组
            #region
            //Console.WriteLine("请随便输入一些内容");
            //string str = Console.ReadLine();
            //char[] chs = new char[str.Length];
            //int i = 0;
            //foreach (char c in str)
            //{
            //    chs[i]=c;
            //    i++;
            //}
            //foreach (char item in chs)
            //{
            //    Console.Write(item);
            //}
            //Console.ReadKey();
            #endregion

            //统计 Welcome to China 中每个字符出现的次数 不考虑大小写
            #region 第一种方法
            //string str = "Welcome to China";
            //str = str.ToUpper();
            //str = str.Trim();
            //List<char> chs = new List<char>();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (!chs.Contains(str[i]))
            //        chs.Add(str[i]);
            //}
            //foreach (char c in chs)
            //{
            //    int counts = 0;
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (c == str[i])
            //            counts++;
            //    }
            //    if (c == ' ')
            //        continue;
            //    else
            //        Console.WriteLine("这句话中{0}共出现{1}次。", c, counts);
            //}
            //Console.ReadKey();
            #endregion

            #region 第二种方法
            string str = "Welcome to China";
            str = str.ToUpper();
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    continue;
                }
                if (dic.ContainsKey(str[i]))
                {
                    dic[str[i]]++;
                }
                else
                {
                    dic[str[i]] = 1;
                }
            }
            foreach  (KeyValuePair<char,int> kv in dic)
            {
                Console.WriteLine("字母{0}出现了{1}次",kv.Key,kv.Value);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
