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

namespace _15._2_DataGridView绑定数据方法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //绑定数据（数据表）
            dataGridView1.DataSource =BindModeSource().Tables[0];
            dataGridView2.DataSource =NonBindMode();

        }

        //绑定模式方法
        private DataSet BindModeSource()
        {
            string constr = "Server=.;user=sa;pwd=sa;database=mydb001";
            SqlConnection mycon = new SqlConnection(constr);
            DataSet myds = new DataSet();
            try
            {
                mycon.Open();
                string sql = "select name,gender from mytable001";
                SqlDataAdapter myda = new SqlDataAdapter(sql,mycon);
                myda.Fill(myds, "mytable001");
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            finally
            {
                mycon.Close();
            }
            return myds;
        }

        //非绑定模式
        private DataTable NonBindMode()
        {
            DataTable mydt = new DataTable();
            mydt.Columns.Add("name",Type.GetType("System.String"));
            mydt.Columns.Add("gender",Type.GetType("System.String"));
            string[,] data = { { "张三", "女" }, { "李四", "男" }, { "王五", "女" }, { "赵六", "女" }, { "何七", "男" } };
            for (int i = 0; i < data.Length / 2; i++)
            {
                DataRow row = mydt.NewRow();
                row[0] = data[i, 0];
                row[1] = data[i, 1];
                mydt.Rows.Add(row);
            }
            return mydt;
        }
    }
}
