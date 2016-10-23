using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _14._15_数据适配DataAdapter对象
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Server=.;user=sa;pwd=sa;database=mydb001";
            SqlConnection mycon = new SqlConnection(constr);

            try
            {
                //mycon.Open();
                //Console.WriteLine("数据库成功打开");

                //string sql = "select * from mytable001";
                //SqlDataAdapter myda = new SqlDataAdapter(sql,mycon);
                //DataSet myds = new DataSet();
                //myda.Fill(myds,"mytable001");
                //Console.WriteLine("填充成功");
                //OutValues(myds);


                //更改数据源文件
                mycon.Open();
                string updatesql = "update mytable001 set gender='女' where name='张三'";
                SqlDataAdapter myda = new SqlDataAdapter("select * from mytable001",mycon);
                myda.UpdateCommand=new SqlCommand(updatesql,mycon);
                DataSet myds = new DataSet();
                myda.Fill(myds, "mytable001");  //acceptchange处于true状态
                Console.WriteLine("原dataset对象内容");
                OutValues(myds);

                DataRow row = myds.Tables[0].Rows[0];
                row["gender"] = "女";
                Console.WriteLine("更改后dataset对象内容");
                myda.Update(myds,"mytable001");
                OutValues(myds);


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            finally
            {
                mycon.Close();
                Console.WriteLine("数据库成功关闭");
            }
            Console.Read();

        }

        //dataset输出方法
        public static void OutValues(DataSet ds)
        {
            foreach (DataTable dt in ds.Tables)
            {
                Console.WriteLine("表名："+dt.TableName);
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        Console.Write(dr[dc]+"\t");
                    }
                    Console.WriteLine();//输出完一行数据后换行
                }
            }
        }
    }
}
