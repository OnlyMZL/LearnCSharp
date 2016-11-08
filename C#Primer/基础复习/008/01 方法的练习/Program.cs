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
            //Console.WriteLine("请输入一个整数");
            //bool b = IsPrimeNumber(Console.ReadLine());
            //Console.WriteLine(b);
            //Console.ReadKey();



            /***************************95******************************
             * 95、接受输入后判断其等级并显示出来。
             * 判断依据如下：等级 ={ 优 （90~100分）；良 （80~89分）；中 （60~69分）；差 （0~59分）；}
             * *******************************************************/

            //Console.WriteLine("请输入成绩");
            //double num = GetDoubleNum(Console.ReadLine());
            //JudgeLevel(num);
            //Console.ReadLine();



            /*****************************97***********************************
             * 97、请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转
             * ***********************************************************************/

            //string[] contries = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            //Console.WriteLine("原数组内容：");
            //for (int i = 0; i < contries.Length; i++)
            //{
            //    Console.Write("\t" + contries[i]);
            //}
            //Console.WriteLine("\n翻转数组内容：");
            //Reverse(contries);  //调用方法翻转数组
            //for (int i = 0; i < contries.Length; i++)
            //{
            //    Console.Write("\t" + contries[i]);
            //}
            //Console.ReadLine();



            /*****************************98********************************
             * 98写一个方法 计算圆的面积和周长  面积是 pI*R*R  周长是 2*Pi*r
             * ***************************************************************/

            //Console.WriteLine("请输入圆的半径");
            //double r=GetDoubleNum(Console.ReadLine());
            //CycleArandLen(r);
            //Console.ReadLine();



            /****************************100***************************************
             * 100、计算任意多个数间的最大值（提示：params）。 
             * ****************************************************/



            /****************************101***************************************
             * 101、请通过冒泡排序法对整数数组{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }实现升序排序。
             * *****************************************************************/
            int[] nums = { 1, 3, 5, 7, 90, 2, 4, 6, 8,10};
            Console.WriteLine("原数组内容");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            BubbleSort(nums);
            Console.WriteLine("升序排列后的数组内容");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();


        }


        /// <summary>
        /// 冒泡排序（升序）
        /// </summary>
        /// <param name="nums">待排序的数组</param>
        public static void BubbleSort(int[] nums)
        {
            int temp = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 0; j < nums.Length-1-i; j++)
                {
                    if (nums[j] > nums[j+1])
                    {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }


        /// <summary>
        /// 计算圆面积和周长并输出
        /// </summary>
        /// <param name="r">圆半径</param>
        public static void CycleArandLen(double r)
        {
            double ar = Math.PI * r * r;
            double len = Math.PI * r * 2;
            Console.WriteLine("圆面积是：{0}\n圆周长是：{1}", ar, len);
        }


        /// <summary>
        /// 翻转数组
        /// </summary>
        /// <param name="s">要反转的数组</param>
        public static void Reverse(string[] s)
        {
            string temp="";
            for (int i = 0; i < s.Length / 2; i++)
            {
                temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }
        }




        /// <summary>
        /// 根据分数判断等级，并输出
        /// </summary>
        /// <param name="num">分数</param>
        public static void JudgeLevel(double num)
        {
            while (true)
            {
                if (num >= 90 && num <= 100)
                {
                    Console.WriteLine("优");
                    break;
                }
                else if (num >= 80 && num < 90)
                {
                    Console.WriteLine("良");
                    break;
                }
                else if (num >= 60 && num < 80)
                {
                    Console.WriteLine("中");
                    break;
                }
                else if (num >= 0 && num < 60)
                {
                    Console.WriteLine("差");
                    break;
                }
                else
                {
                    Console.WriteLine("输入有误，请重新输入");
                    num = GetDoubleNum(Console.ReadLine());
                }
            }
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
        /// 将用户输入转换为double类型数字
        /// </summary>
        /// <param name="s">用户输入的内容</param>
        /// <returns>返回double类型数字</returns>
        public static double GetDoubleNum(string s)
        {
            double num = 0;
            while (true)
            {
                try
                {
                    num = Convert.ToDouble(s);
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
        /// 将用户输入的内容转换为整数
        /// </summary>
        /// <param name="s">用户输入的内容</param>
        /// <returns>返回整数</returns>
        public static int GetIntNum(string s)
        {
            int num = 0;
            while (true)
            {
                try
                {
                    num = Convert.ToInt32(s);
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
