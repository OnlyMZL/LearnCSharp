using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03P27单链表表示线性表
{
    class SLinkList<T> : ILinarList<T>
    {
        private SNode<T> start;  //单链表的头引用
        int length;  //单链表的长度
        
        //初始化单链表
        public SLinkList()
        {
            start = null;
        }

        /// <summary>
        /// 向单链表末尾插入数据元素
        /// </summary>
        /// <param name="a">数据元素</param>
        public void InsertNode(T a)
        {
            if (start == null)  //空表时
            {
                start = new SNode<T>(a);
                length++;
                return;
            }
            else   //非空表时
            {
                SNode<T> current = start;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new SNode<T>(a);
            }
            length++;
        }

        /// <summary>
        /// 向单链表中某位置插入一个数据元素
        /// </summary>
        /// <param name="a">数据元素</param>
        /// <param name="i">插入位置</param>
        public void InsertNode(T a, int i)
        {
            SNode<T> current;
            SNode<T> previous;
            SNode<T> newNode = new SNode<T>(a);
            if (i == 1)   //在首位插入
            {
                newNode.Next = start;
                start = newNode;
                length++;
                return;
            }
            else if (i < 1 || i > length + 1)   //插入位置超出表
            {
                Console.WriteLine("WRONG POSITION!");
                return;
            }
            else  //在表中插入
            {
                current = start;
                previous = null;
                int j = 1;
                while (current != null && j < i)
                {
                    previous = current;
                    current = current.Next;
                    j++;
                }
                
                if (j == i)
                {
                    previous.Next = newNode;
                    newNode.Next = current;
                    length++;
                }
            }
        }

        public void SearchNode(T a)
        {
            for (int i = 0; i < length; i++)
            {

            }
        }

        public T SearchNode(int i)
        {
            throw new NotImplementedException();
        }
        public void DeleteNode(int i)
        {
            throw new NotImplementedException();
        }
        

    }
}