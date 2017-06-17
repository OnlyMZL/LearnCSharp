using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH01
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试SeqStructure类
            TestSeqStructure();

            //测试LinkedStructure类
            TestLinkedStructure();
            Console.ReadLine();

        }

        public static void TestSeqStructure()
        {
            string s1 = "red";
            string s2 = "blue";
            string s3 = "yellow";
            SeqStructure<string> s = new SeqStructure<string>(3);
            s.addData(s1);
            s.addData(s2);
            s.addData(s3);
            s.displayData();
        }

        public static void TestLinkedStructure()
        {
            string s1 = "red";
            string s2 = "blue";
            string s3 = "yellow";
            LinkedStructure<string> l = new LinkedStructure<string>();
            l.addData(new LinkedNode<string>(s1));
            l.addData(new LinkedNode<string>(s2));
            l.addData(new LinkedNode<string>(s3));
            l.displayData();
        }
    }
}
