using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03P27单链表表示线性表
{
    interface ILinarList<T>
    {
        void InsertNode(T a, int i);  //插入操作
        void DeleteNode(int i);  //删除操作
        T SearchNode(int i);  //按位置取数据元素
        void SearchNode(T a);  //按值查找位置
    }
}