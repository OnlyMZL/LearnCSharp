using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_ComboBox控件
{
    public partial class Form1 : Form
    {
        string year;         //声明变量存储年份
        string month;        //声明变量存储月份

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 2016; i >= 1949; i--)
            {
                cboYear.Items.Add(i + "年");
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblChecked.Text = "";
            cboMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cboMonth.Items.Add(i + "月");
            }
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblChecked.Text = "";
            cboDay.Items.Clear();
            year = cboYear.SelectedItem.ToString();
            month = cboMonth.SelectedItem.ToString();
            //获得年份
            month = month.Split(new char[] { '月' }, StringSplitOptions.RemoveEmptyEntries)[0];
            int intMonth = Convert.ToInt32(month);
            //获得月份
            year = year.Split(new char[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0];
            int intYear = Convert.ToInt32(year);
            //增加天数
            int days = 0;
            if (new int[] { 1, 3, 5, 7, 8, 10, 12 }.Contains(intMonth))
            {
                days = 31;
            }
            else if (new int[] { 4, 6, 9, 11 }.Contains(intMonth))
            {
                days = 30;
            }
            else
            {
                if (intYear % 400 == 0 || (intYear % 100 != 0 && intYear % 4 == 0))
                {
                    days = 29;
                }
                else
                {
                    days = 28;
                }
            }
            for (int i = 1; i <= days; i++)
            {
                cboDay.Items.Add(i + "日");
            }
        }

        private void cboDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblChecked.Text = cboYear.SelectedItem.ToString() + cboMonth.SelectedItem.ToString() + cboDay.SelectedItem.ToString();
        }


    }
}
