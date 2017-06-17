using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH01
{
    /// <summary>
    /// 用链式存储结构存放数据结构
    /// </summary>
    /// <typeparam name="T"></typeparam>
    
    //数据元素存储表示
    class LinkedNode<T>
    {
        T data;
        LinkedNode<T> next;  //通过引用将随机存放的元素连接起来
        public LinkedNode(T val)
        {
            data = val;
            next = null;
        }
        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public LinkedNode<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }//class LinkedNode


    //数据元素关系的存储表示及算法实现
    class LinkedStructure<T>
    {
        LinkedNode<T> first;
        LinkedNode<T> current;

        public LinkedStructure()
        {
            first = null;
        }
        public void addData(LinkedNode<T> var)
        {
            if (first==null)
            {
                first = var;
                current = var;
                return;
            }
            else
            {
                current.Next = var;
                current = var;
            }
        }
        public void displayData()
        {
            current = first;
            while(current!=null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
        }
    }//class LinkedStructure
} //namespace CH01
