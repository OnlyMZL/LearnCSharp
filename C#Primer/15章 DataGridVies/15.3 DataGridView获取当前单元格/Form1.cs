using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._3_DataGridView获取当前单元格
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“mydb001DataSet.mytable001”中。您可以根据需要移动或删除它。
            this.mytable001TableAdapter.Fill(this.mydb001DataSet.mytable001);

        }


        //cellclick事件
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //第一种获取行列的方法
            int row = e.RowIndex + 1;
            int column = e.ColumnIndex + 1;


            //第二种获取行列的方法
            //string row = (dataGridView1.CurrentCell.RowIndex+1).ToString();
            //string column = (dataGridView1.CurrentCell.ColumnIndex+1).ToString();


            //第三种获取行列的方法
            //int row = dataGridView1.CurrentCellAddress.Y + 1;
            //int column = dataGridView1.CurrentCellAddress.X + 1;


            //第四种获取行的方法
            //int row = dataGridView1.CurrentRow.Index + 1;


            //获取单元格内容的方式
            string currentcell = dataGridView1.CurrentCell.Value.ToString();
            //string currentcell = dataGridView1.Rows[row].Cells[column].Value.ToString();


            //内容输出
            MessageBox.Show("当前选中的单元格位于表的第"+row+"行，第"+column+"列"+
                            "\n当前单元格内容为"+currentcell,"内容提示框");

        }
    }
}
