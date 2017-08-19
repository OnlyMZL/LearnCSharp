using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字典Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建字典，并添加元素
            Dictionary<string, string> dictCast = new Dictionary<string, string>();
            dictCast.Add("哈利·贝瑞", "死囚之舞");
            dictCast.Add("朱迪·丹奇", "携手人生");
            dictCast.Add("巩俐", "少年汉尼拔");

            //删除元素
            dictCast.Remove("朱迪·丹奇");

            //加入不存在，则加入元素
            if (!dictCast.ContainsKey("朱迪·丹奇1"))
            {
                dictCast.Add("朱迪·丹奇1", "携手人生");
            }

            //获取元素个数
            int dictCount = dictCast.Count;
            Console.WriteLine(dictCount);

            //遍历集合
            foreach (var item in dictCast)
            {
                Console.WriteLine("TKey:{0}\t TValue:{1}",item.Key,item.Value);
            }

            //获取键的集合
            List<string> keyList = new List<string>();
            foreach (var item in dictCast.Keys)
            {
                keyList.Add(item);
            }
            //获取值的集合
            List<string> valueList = new List<string>();
            foreach (var item in dictCast.Values)
            {
                valueList.Add(item);
            }

            //通过键获取值
            Console.WriteLine(dictCast["朱迪·丹奇1"]);

            //获取键值对KeyValuePair<TKey,TValue>集合
            List<KeyValuePair<string, string>> kvPairList = new List<KeyValuePair<string, string>>();
            foreach (KeyValuePair<string,string> item in dictCast)
            {
                kvPairList.Add(item);
            }

            //获取键值
            string value = "";
            dictCast.TryGetValue("朱迪·丹奇1", out value);
            Console.WriteLine(value);

            Console.ReadKey();
        }
    }
}
