using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组_ArrayList_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组声明时要指定数组长度，数组的长度是不可变的。
            //数组在内存中是连续存储的，所以索引速度快，赋值和修改元素也简单。
            string[] sb = new string[2];
            sb[0] = "a";  //赋值
            sb[1] = "b";
            sb[0] = "c";  //修改
            foreach (var s in sb)
            {
                Console.WriteLine(s);
            }

            //使用ArrayList类要先引用System.Collections名称空间
            //ArrayList类实例的大小可以按其中存储的数据动态扩充和收缩。
            //ArrayList类实例中可以插入不同的类型，并会把数据当作boject类型处理，所以类型不安全。
            //存储或检索值类型时通常发生装箱和拆箱操作，损耗性能。
            ArrayList arrayList = new ArrayList();
            arrayList.Add("abc");
            for (int i = 0; i < 5; i++)
            {
                arrayList.Add(i);
            }
            arrayList.Insert(2, "insert");
            arrayList.Remove(5);
            arrayList.Remove(3);
            foreach (var elem in arrayList)
            {
                Console.WriteLine(elem.ToString());
            }

            //因为ArrayList存在不安全类型与装箱拆箱的缺点，所以出现了泛型的概念。
            //List类是ArrayList类的泛型等效类，它的大部分用法与ArrayList类似。
            //关键区别在于：声明List集合时，需要同时声明List集合内数据的对象类型
            List<string> sList = new List<string>();
            sList.Add("abc");
            sList.Add("def");
            sList.Insert(1, "ghi");

            for (int i = 0; i < 5; i++)
            {
                sList.Add(i.ToString());
            }
            sList[4] = "jkl";
            sList.Remove(1.ToString());
            sList.RemoveAt(0);

            foreach (var item in sList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(sList.Capacity);

            Console.ReadKey();
        }
    }
}
