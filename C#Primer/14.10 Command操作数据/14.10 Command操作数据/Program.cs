using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _14._10_Command操作数据
{
    class Program
    {
        static void Main(string[] args)
        {
            //连接数据库
            string constr = "Server=.;user=sa;pwd=sa;database=mydb001";
            SqlConnection mysqlCon = new SqlConnection(constr);

            //Command操作数据
            try
            {
                ////创建Command对象过程
                //mysqlCon.Open();
                //Console.WriteLine("数据库连接成功");
                //string sql = "select * from mytable001";
                //SqlCommand mysqlCom = new SqlCommand(sql,mysqlCon);
                //mysqlCom.CommandTimeout = 2;
                //Console.WriteLine("创建数据库命令对象成功");

                ////更改数据，ExecuteNonQuery()方法
                //mysqlCon.Open();
                //string sql = "insert mytable001(name,gender,age,department)values('雪上行者','男',25,'开发部')";
                //SqlCommand mysqlCom = new SqlCommand(sql, mysqlCon);
                //mysqlCom.ExecuteNonQuery();  //实现数据更改的语句
                //Console.WriteLine("数据库内容更改成功");

                //更改数据，EcecuteScalar()方法
                mysqlCon.Open();
                string sql = "select max(age) from mytable001";
                SqlCommand myCom = new SqlCommand(sql, mysqlCon);
                int t;
                t=(int)myCom.ExecuteScalar();
                Console.WriteLine("年龄最大的是"+t+"岁");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                mysqlCon.Close();
                Console.WriteLine("数据库成功关闭");
            }
            Console.Read();
        }
    }
}
