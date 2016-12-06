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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //连接数据库
            string constr = "server=.;user=sa;pwd=sa;database=mydb001";
            SqlConnection conn = new SqlConnection(constr);
            using (conn)
            {
                conn.Open();
                MessageBox.Show("数据库连接成功", "提示信息");

                #region SqlCommand使用
                ////插入数据  ExecuteNonQuery方法
                //SqlCommand cmd = new SqlCommand("insert into mytable001(name) values('111')", conn);
                //int i = cmd.ExecuteNonQuery();
                //MessageBox.Show(i + "行受影响", "提示信息");
                ////删除数据
                //SqlCommand cmd2 = new SqlCommand("delete from mytable001 where name='111'", conn);
                //int j = cmd2.ExecuteNonQuery();
                //MessageBox.Show(j + "行受影响", "提示信息");
                #endregion

                conn.Close();
                MessageBox.Show("数据库关闭成功", "提示");
                conn.Dispose();

            }
        }
    }
}
