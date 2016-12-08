using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _01_ADO.NET连接
{

    public enum SqlCommandFunction  //声明枚举，判断要执行的SqlCommand的方法
    {
        ExecuteNonQuery,
        ExecuteScalar,
        ExecuteReader
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            ////连接数据库
            //string constr = "server=.;user=sa;pwd=sa;database=mydb001";
            //SqlConnection conn = new SqlConnection(constr);
            //using (conn)
            //{
            //    conn.Open();
            //    MessageBox.Show("数据库连接成功", "提示信息");

            //    #region SqlCommand使用
            //    ////插入数据  ExecuteNonQuery方法
            //    //SqlCommand cmd = new SqlCommand("insert into mytable001(name) values('111')", conn);
            //    //int i = cmd.ExecuteNonQuery();
            //    //MessageBox.Show(i + "行受影响", "提示信息");
            //    ////删除数据
            //    //SqlCommand cmd2 = new SqlCommand("delete from mytable001 where name='111'", conn);
            //    //int j = cmd2.ExecuteNonQuery();
            //    //MessageBox.Show(j + "行受影响", "提示信息");
            //    #endregion

            //    conn.Close();
            //    MessageBox.Show("数据库关闭成功", "提示");
            //    conn.Dispose();

            //}
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //连接数据库
            SqlConnection conn = GetSqlConnection();
            //执行数据库命令
            GetSqlCommand("insert into mytable001(name) values('" + txtInsert.Text + "')", conn,SqlCommandFunction.ExecuteNonQuery);
            GetSqlCommand("delete from mytable001 where age<18", conn,SqlCommandFunction.ExecuteNonQuery);
            //关闭数据库并释放资源
            CloseSqlConnection(conn);
        }
        
        private void btnId_Click(object sender, EventArgs e)
        {
            SqlConnection conn = GetSqlConnection();
            string str = (string)GetSqlCommand("select department from mytable001 where id=" + txtId.Text, conn, SqlCommandFunction.ExecuteScalar);
            MessageBox.Show(str);
        }

        
        #region 封装的数据库方法
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns>连接到的数据库对象</returns>
        public static SqlConnection GetSqlConnection()
        {
            string constr = "server=.;user=sa;pwd=sa;database=mydb001";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            return conn;
        }
        /// <summary>
        /// 执行数据库命令  SqlCommand
        /// </summary>
        /// <param name="str">要执行的命令</param>
        /// <param name="conn">已经打开的数据库连接</param>
        /// <param name="fun">cmd要执行的方法</param>
        /// <returns>cmd执行方法的返回内容</returns>
        public static object GetSqlCommand(string str, SqlConnection conn, SqlCommandFunction fun)
        {
            object obj;
            SqlCommand cmd = new SqlCommand(str, conn);
            switch ((int)fun)
            {
                case 0: obj = cmd.ExecuteNonQuery(); break;
                case 1: obj = cmd.ExecuteScalar(); break;
                case 2: obj = cmd.ExecuteReader(); break;
                default:
                    obj = null;
                    MessageBox.Show("命令执行失败");
                    break;
            }
            return obj;
        }
        /// <summary>
        /// 关闭数据库
        /// </summary>
        /// <param name="conn">已经打开的数据库</param>
        public static void CloseSqlConnection(SqlConnection conn)
        {
            conn.Close();
            conn.Dispose();
            MessageBox.Show("数据库成功关闭", "提示");
        }

        #endregion


    }
}
