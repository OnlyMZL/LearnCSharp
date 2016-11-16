using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03_文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、读取文件内容
            ////创建FileStream类对象
            //FileStream stRead = new FileStream(@"E:\C#\st.txt",FileMode.OpenOrCreate,FileAccess.Read);
            ////声明一个5M 的字节数组
            //byte[] buffer = new byte[1024 * 1024 * 5];
            ////声明变量存储实际读取到的字节数
            //int r= stRead.Read(buffer, 0, buffer.Length);
            ////将指定字节数组的一个字节序列转换成字符串
            //string str = Encoding.Default.GetString(buffer,0,r);
            //Console.WriteLine(str);
            ////关闭流
            //stRead.Close();
            ////释放内存
            //stRead.Dispose();
            //Console.ReadKey();


            //2、写入文件数据
            //创建FileStream类对象
            //using (FileStream stWrite = new FileStream(@"E:\C#\st.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    string str = "33333333";
            //    byte[] buffer = Encoding.Default.GetBytes(str);
            //    stWrite.Write(buffer, 0, buffer.Length);
            //}
            //Console.WriteLine("写入成功");
            //Console.ReadKey();


            //3、通过FileStream类复制多媒体文件
            string source = @"E:\C#\1.avi";
            string target = @"E:\C#\2.avi";
            CopyTo(source,target);
            Console.WriteLine("写入成功");
            Console.ReadKey();
        }

        /// <summary>
        /// 复制source数据到target
        /// </summary>
        /// <param name="source">数据源路径</param>
        /// <param name="target">目标路径</param>
        public static void CopyTo(string source, string target)
        {
            using (FileStream fsRead = new FileStream(source, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int r = 1;
                    while (true)
                    {
                        r = fsRead.Read(buffer, 0, buffer.Length);
                        if (r == 0)
                            break;
                        fsWrite.Write(buffer, 0, r);
                    }
                }
            }
        }
        
    }
}
