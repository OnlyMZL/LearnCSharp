using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _01_MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = GetMD5("123");
            Console.WriteLine(str);
            Console.ReadKey();
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <returns>返回加密过的字符串</returns>
        public static string GetMD5(string str)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //开始加密
            //需要将字符串转换成字节数组
            byte[] buffer = Encoding.Default.GetBytes(str);
            //返回一个加密好的字节数组
            byte[] Md5buffer = md5.ComputeHash(buffer);

            string newstr = "";
            for (int i = 0; i < Md5buffer.Length; i++)
            {
                newstr += Md5buffer[i].ToString("x2"); 
            }
            return newstr;
        }

    }
}
