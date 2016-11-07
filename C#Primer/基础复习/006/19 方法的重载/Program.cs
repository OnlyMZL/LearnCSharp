using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(M(1, 2));
            Console.WriteLine(M(1.2, 3.4));
            Console.WriteLine(M("123", "456"));
            Console.ReadLine();
        }

        #region  M方法  4个重载
        public static int M(int n1, int n2)
        {
            return n1 + n2;
        }
        public static double M(double n1, double n2)
        {
            return n1 + n2;
        }
        public static string M(string n1, string n2)
        {
            return n1 + n2;
        }
        public static decimal M(decimal n1, decimal n2)
        {
            return n1 + n2;
        }
        public static float M(float n1,float n2)
        {
            return n1 + n2;
        }
        #endregion

    }
}
