using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH01
{
    /// <summary>
    /// 顺序存储结构存放数据结构
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SeqStructure<T>
    {
        T[] data;
        int i;
        public SeqStructure(int size)   //类的构造函数
        {
            data = new T[size];
        }

        public void addData(T var)
        {
            data[i++] = var;
        }
        public void displayData()
        {
            for (int j = 0; j < data.Length; j++)
            {
                Console.WriteLine(data[j]+" ");
            }
        }
    }
}
