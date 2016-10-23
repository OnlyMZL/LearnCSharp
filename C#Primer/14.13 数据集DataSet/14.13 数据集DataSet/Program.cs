using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _14._13_数据集DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 创建dataset对象
            DataSet myds = new DataSet("csharp51zxw");
            //2 创建datatable对象
            DataTable mydt = new DataTable("mytable001");
            //3 将datatable对象添加到dataset中
            myds.Tables.Add(mydt);
            //4 创建列
            DataColumn mydcol1 = new DataColumn("id",Type.GetType("System.Int32"));
            DataColumn mydcol2 = new DataColumn("name", Type.GetType("System.String"));
            DataColumn mydcol3 = new DataColumn("department", Type.GetType("System.String"));
            //5 将创建的列添加到datatable中
            mydt.Columns.Add(mydcol1);
            mydt.Columns.Add(mydcol2);
            mydt.Columns.Add(mydcol3);
            //6 创建行,并添加到表中
            string[,] rowstr={  { "张三","开发部"} ,
                              { "李四", "销售部" },
                              { "王五", "技术支持部" },
                              { "赵六", "人事部" },
                              { "刘七", "项目部" }};
            for (int i = 0; i < rowstr.Length / 2; i++)
            {
                DataRow myrow = mydt.NewRow();
                myrow[0] = i+1;
                myrow["name"] = rowstr[i, 0];
                myrow[2] = rowstr[i, 1];
                mydt.Rows.Add(myrow);
            }
            //7 保存
            myds.AcceptChanges();
            Console.WriteLine("更改前的数据");
            //遍历dataset
            outValues(myds);

            //Clone方法
            DataTable mydt002 = mydt.Clone();
            DataRow mydr = mydt002.NewRow();
            mydt002.Rows.Add(new object[] { 6,"王二","技术部"});
            mydt002.Rows.Add(new object[] { 7, "张小虎", "开发部" });
            //将mydt002及其架构合并到myds中
            myds.Merge(mydt002);
            Console.WriteLine("\n"+"合并后的数据集：");
            outValues(myds);

            DataSet myds001 = myds.Copy();
            DataSet myds002 = myds.Clone();

            Console.WriteLine("Copy方法的结果");//复制dataset的结构和数据
            outValues(myds001);
            Console.WriteLine("Clone方法的结果");//只复制dataset的结构
            outValues(myds002);

            Console.Read();

            //string constr = "Server=.;user=sa;pwd=sa;database=mydb001";
            //SqlConnection myCon = new SqlConnection(constr);
            //try
            //{

            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message.ToString());
            //}
            //finally
            //{

            //}
        }


        //实现遍历dataset对象
        public static void outValues(DataSet ds)
        {
            foreach (DataTable outtable in ds.Tables)
            {
                Console.WriteLine("表名称："+outtable.TableName);
                foreach (DataRow outdr in outtable.Rows)
                {
                    foreach (DataColumn outdcol in outtable.Columns)
                    {
                        Console.Write(outdr[outdcol]+"\t");
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
