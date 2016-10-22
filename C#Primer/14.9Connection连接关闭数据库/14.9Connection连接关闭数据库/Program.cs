using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace _14._9Connection连接关闭数据库
{
    class Program
    {
        static void Main(string[] args)
        {
            //数据库的连接分为两种方式
            //①SQL server数据库
            //②widows身份验证实现登陆并打开数据库

            //windows身份验证打开数据库
            //string constr = "Server=.;integrated security=SSPI;Initial Catalog=mydb001";

            //SQL Server方式打开
            string constr = "Server=.;user=sa;pwd=sa;database=mydb001";
            SqlConnection mysqlCon = new SqlConnection(constr);
            //mysqlCon.Open();
            //Console.WriteLine("数据库成功打开。。。");
            //mysqlCon.Close();
            //Console.WriteLine("数据库关闭成功。。。");


            ////通过using语句实现数据库的关闭，数据库使用完毕后会自动关闭
            //using (mysqlCon)
            //{
            //    mysqlCon.Open();
            //    Console.WriteLine("数据库成功打开。。。");
            //}


            //通过try。。catch。。finally。。实现数据库的实时关闭 
            //try
            //{
            //    mysqlCon.Open();
            //    Console.WriteLine("数据库成功打开。。。");
            //}
            //catch
            //{

            //}
            //finally
            //{
            //    mysqlCon.Close();
            //    Console.WriteLine("数据库成功关闭。。。");
            //}


            //通过以上两种方式的结合使用来自动关闭数据库
            try
            {
                using (mysqlCon)
                {
                    mysqlCon.Open();
                    Console.WriteLine("数据库成功打开。。。");
                }
            }
            catch
            {

            }
            finally
            {
                mysqlCon.Close();
                Console.WriteLine("数据库成功关闭。。。");
            }
            Console.Read();
        }
    }
}
