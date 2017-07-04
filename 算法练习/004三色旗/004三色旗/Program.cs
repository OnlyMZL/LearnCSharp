using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004三色旗
{
    class Program
    {
        static int count = 0;  //计数器，计最少交换次数
        static void Main(string[] args)
        {
            char[] cArray = new char[] { 'B', 'R', 'B', 'W','B' ,'W'};
            int b = 0, w = 0;   //指针变量
            int r = cArray.Length - 1;   //指针变量
            Console.WriteLine("原三色旗顺序：");
            DisplayArray(cArray);
            cArray = SortArray(cArray, b, w, r);  //排序
            Console.WriteLine("排序后三色旗顺序：");
            DisplayArray(cArray);
            Console.WriteLine("最少交换次数：{0}",count);
            Console.ReadKey();
        }

        /// <summary>
        /// 将三色旗按蓝、白、红顺序排列
        /// </summary>
        /// <param name="cArray"> </param>
        /// <param name="b"></param>
        /// <param name="w"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        static char[] SortArray(char[] cArray, int b, int w, int r)
        {
            while (w <= r)
            {
                switch (cArray[w])
                {
                    case 'R':
                        char temp = ' ';
                        temp = cArray[w];
                        cArray[w] = cArray[r];
                        cArray[r] = temp;
                        r--;
                        count++;
                        break;
                    case 'B':
                        if (b<w)
                        {
                            char temp1 = ' ';
                            temp1 = cArray[w];
                            cArray[w] = cArray[b];
                            cArray[b] = temp1;
                            count++;
                        }
                        w++;
                        b++;
                        break;
                    case 'W':
                        w++;
                        break;
                }
            }
            return cArray;
        }

        /// <summary>
        /// 遍历数组
        /// </summary>
        /// <param name="cArray"></param>
        static void DisplayArray(char[] cArray)
        {
            for (int i = 0; i < cArray.Length; i++)
            {
                Console.Write(cArray[i].ToString() + ',');
            }
            Console.WriteLine();
        }


        //static void swipR(char[] cArray,int i, int j)
        //{
        //    char temp = ' ';
        //    temp = cArray[i];
        //    cArray[i] = cArray[j];
        //    cArray[j] = temp;
        //    j--;
        //}

        //static void swipB(char[] cArray, int i, int j)
        //{
        //    //char temp = ' ';
        //    //temp = cArray[i];
        //    //cArray[i] = cArray[j];
        //    //cArray[j] = temp;
        //    i++ ;
        //    j++;
        //}








    }
}
