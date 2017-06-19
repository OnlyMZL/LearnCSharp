using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02P14顺序表解决线性表的编程问题
{
    public class SeqList<T> : IlinarList<T>
    {
        private int maxsize;  //顺序表的最大容量
        private T[] data;  //数组，用于存储顺序表中的数据元素
        private int length;  //顺序表的实际长度 

        //最大容量属性
        public int Maxsize
        {
            get { return maxsize; }
            set { maxsize = value; }
        }
        //实际长度属性
        public int Length
        {
            get { return length; }
        }

        //初始化线性表，三个条件
        public SeqList(int size)
        {
            maxsize = size;
            data = new T[maxsize];
            length = 0;
        }

        /// <summary>
        /// 清空线性表
        /// </summary>
        public void Clear()
        {
            length = 0;
        }

        /// <summary>
        /// 删除线性表某一位置数据元素
        /// </summary>
        /// <param name="i">删除位置</param>
        public void DeleteNode(int i)
        {
            if (length == 0)  //空表时
            {
                Console.WriteLine("ERROR! EMPETY!");
            }
            else if (i < 1 || i >= length) 
            {
                Console.WriteLine("INVALID POSITION!");
            }
            else
            {
                for (int j = i-1; j < length; j++)
                {
                    data[j] = data[j + 1];
                }
                length--;
            }
        }

        public int GetLength()
        {
            return length;
        }

        /// <summary>
        /// 向顺序表中插入数据元素，未规定插入位置，默认插入表末尾
        /// </summary>
        /// <param name="a">数据元素</param>
        public void InsertNode(T a)
        {
            if (length < maxsize)
            {
                data[length] = a;
                length++;
            }
            else
            { Console.WriteLine("ERROR! CHECK INPUT!"); }
        }
        /// <summary>
        /// 向顺序表中插入数据元素
        /// </summary>
        /// <param name="a">数据元素</param>
        /// <param name="i">插入位置</param>
        public void InsertNode(T a, int i)
        {
            if (length == 0)  //线性表长度为0
            {
                if (i == 1)
                {
                    data[0] = a;
                    length++;
                }
                else
                {
                    Console.WriteLine("INVALID POSITION!");
                    return;
                }
            }
            else if (i < 1 || i > length + 1)  //插入位置为第一位位，或插入位置在线性表长度的后两位
            {
                Console.WriteLine("INVALID POSITION!");
                return;
            }
            else if (i >= 1 && i <= length + 1)  //线性表长度大于0，且插入位置合理
            {
                for (int j = length - 1; j >= i - 1; j--)
                {
                    data[j + 1] = data[j];
                }
                data[i - 1] = a;
                length++;
            }
        }

        public bool IsEmpty()
        {
            if (length == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 根据数据元素查找位置
        /// </summary>
        /// <param name="value">数据元素值</param>
        public void SearchNodeByValue(T value)
        {
            int j=0;
            int[] sData=new int[length];
            for (int i = 0; i < length; i++)
            {
                if (data[i].Equals(value))
                {
                    sData[j] = i+1;
                    j++;
                }
            }
            for (int i = 0; i < j; i++)
            {
                if(j!=0)
                    Console.WriteLine(sData[i]);
                else
                    Console.WriteLine("NO VALUE!");
            }
        }

        /// <summary>
        /// 根据位置查找数据元素值
        /// </summary>
        /// <param name="i">位置</param>
        /// <returns>数据元素</returns>
        public T SearchNodeBySeat(int i)
        {
            return data[i - 1];
        }
    }
}
