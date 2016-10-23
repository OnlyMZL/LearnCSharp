using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace _14._17_案例小结
{
    class Program
    {
        /* 利用SQL语句创建数据库Company，在其中创建一个Clerk表，表中存放
         * 员工的姓名、性别、年龄、入职时间、部门
         * 然后向表中添加几条数据
         * 
         * 一 通过DataReader 打印出所建表的信息
         * 二 通过dataset 打印出所建表的信息
         * 
         */

        static void Main(string[] args)
        {
            string constr = "Server=.;user=sa;pwd=sa;database=company";
            SqlConnection mycon = new SqlConnection(constr);

            try
            {
                #region 一 通过DataReader 打印出所建表的信息
                //mycon.Open();
                //string sql = "select * from clerk";
                //SqlCommand mycom = new SqlCommand(sql, mycon);
                //SqlDataReader myDataReader = mycom.ExecuteReader();
                //Console.WriteLine("使用datareader打印输出");
                ////打印表头
                //for (int i = 0; i < myDataReader.FieldCount; i++)
                //{
                //    Console.Write(myDataReader.GetName(i)+"\t");
                //}
                //Console.WriteLine();
                ////打印表中数据
                //while (myDataReader.Read())//每次读取一行，循环中，没读取一次，继续读取下一行
                //{
                //    if (myDataReader.HasRows)
                //    {
                //        for (int i = 0; i < myDataReader.FieldCount; i++)
                //        {
                //            Console.Write(myDataReader[i].ToString() + "\t");
                //        }
                //        Console.WriteLine();
                //    }

                //}
                ////关闭datareader对象
                //myDataReader.Close();
                #endregion

                #region 二 通过dataset 打印出所建表的信息
                mycon.Open();
                string sql = "select * from clerk";
                SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql,mycon);
                DataSet myDataSet = new DataSet();
                myDataAdapter.Fill(myDataSet,"mytable001");
                Console.WriteLine("使用dataadapter打印表信息");
                //打印表头
                foreach (DataTable table in myDataSet.Tables)
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        Console.Write(col.ColumnName+"\t");
                    }
                    Console.WriteLine();
                }
                //调用方法打印表内容
                OutValuesFromDataSet(myDataSet);

                #endregion
            }
            catch (Exception e)
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

        /// <summary>
        /// 打印dataset对象
        /// </summary>
        /// <param name="ds">数据集dataset</param>
        public static void OutValuesFromDataSet(DataSet ds)
        {
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow drow in dt.Rows)
                {
                    foreach (DataColumn dcol in dt.Columns)
                    {
                        Console.Write(drow[dcol].ToString()+"\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
