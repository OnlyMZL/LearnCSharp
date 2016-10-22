using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _14._11_DataReader读取数据
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Server=.;user=sa;pwd=sa;database=mydb001";
            SqlConnection myCon = new SqlConnection(constr);
            try
            {
                myCon.Open();
                string sql = "select * from mytable001 where gender='男'";
                SqlCommand myCom = new SqlCommand(sql,myCon);
                //声明DataReader对象
                SqlDataReader mydr;
                mydr = myCom.ExecuteReader();
                if (mydr.HasRows)
                {
                    Console.WriteLine("mytable001中存在数据");
                }
                else
                {
                    Console.WriteLine("mytable001不存在数据");
                }
                //Console.WriteLine(mydr.FieldCount);   //获取mytable001中的字段数
                //Console.WriteLine(mydr.IsClosed);
                //Console.WriteLine( mydr.GetDataTypeName(2) ); 
                //Console.WriteLine(mydr.GetOrdinal("id"));
                //if(mydr.Read())
                //Console.WriteLine(mydr.GetValue(1)); 


                //object[] myobj = new object[mydr.FieldCount];
                //while (mydr.Read())
                //{
                //    mydr.GetValues(myobj);
                //    foreach (object outobj in myobj)
                //        {
                //            Console.Write(outobj + "\t");
                //        }
                //    Console.WriteLine();
                //}


                while (mydr.Read())
                {
                    Console.Write(mydr[0].ToString()+",");
                    Console.Write(mydr[1].ToString()+",");
                    Console.Write(mydr["gender"].ToString() + ",");
                    Console.Write(mydr["department"].ToString() + ",");

                    Console.WriteLine();
                }
                mydr.Close();
                //Console.WriteLine(mydr.IsClosed);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                myCon.Close();
            }
            Console.Read();
        }
    }
}
