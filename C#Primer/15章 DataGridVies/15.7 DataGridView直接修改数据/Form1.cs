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


namespace _15._7_DataGridView直接修改数据
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvBind();
        }

        //连接数据库
        private SqlConnection GetConnection()
        {
            string constr = "Server=.;user=sa;pwd=sa;database=mydb001";
            SqlConnection mycon = new SqlConnection(constr);
            return mycon;
        }

        private void dgvBind()
        {
            SqlConnection mycon = GetConnection();
            try
            {
                mycon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from mytable001", mycon);
                DataTable table = new DataTable();
                sda.Fill(table);
                this.dataGridView1.AutoGenerateColumns = true;  //按数据框架自动生成列
                this.dataGridView1.DataSource = table;
                dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            }
            catch(Exception e)
            {
                MessageBox.Show("ERROR",e.Message.ToString());
            }
            finally
            {
                mycon.Close();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection mycon = GetConnection();
            try
            {
                mycon.Open();

                //获取单元格的值和修改的内容
                string mystr1=dataGridView1.Columns[e.ColumnIndex].HeaderText+"="+"'"+dataGridView1.CurrentCell.Value.ToString()+"'";
                string mystr2=dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string updateSql = "update mytable001 set "+mystr1+" where id="+mystr2;
                SqlCommand mycom = new SqlCommand(updateSql,mycon);
                mycom.ExecuteNonQuery();
                dgvBind(); //更新显示源数据

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR", ex.Message.ToString());
            }
            finally
            {
                mycon.Close();
            }

        }
    }
}
