using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02P14顺序表解决线性表的编程问题
{
    interface IlinarList<T>
    {
        void InsertNode(T a, int i);  //插入操作
        void DeleteNode(int i);  //删除操作
        T SearchNodeBySeat(int i);   //查找表元素
        void SearchNodeByValue(T value);  //定位元素
        int GetLength();  //求表长度
        void Clear();  //清空操作
        bool IsEmpty();  //判断线性表是否为空
    }
}
