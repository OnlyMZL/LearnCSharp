using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03P27单链表表示线性表
{
    class SNode<T>
    {
        private T data;  //数据域
        private SNode<T> next;  //引用域

        //数据域属性
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        //引用域属性
        public SNode<T> Next
        {
            get { return next; }
            set { Next = value; }
        }

        //类的构造函数
        public SNode(T val, SNode<T> p)  //中间节点
        {
            data = val;
            next = p;
        }
        public SNode(T val)  //尾节点
        {
            data = val;
            next = null;
        }
        public SNode(SNode<T> p)  //首节点
        {
            next = p;
        }
        public SNode()
        {
            data = default(T);
            next = null;
        }
    }
}