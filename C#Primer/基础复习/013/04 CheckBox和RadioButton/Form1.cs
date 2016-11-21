using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_CheckBox和RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rbtnStudent.Checked && txtUsername.Text == "student" && txtPwd.Text == "student")
            {
                MessageBox.Show("学生登陆成功");
            }
            else if (rbtnTeacher.Checked && txtUsername.Text == "teacher" && txtPwd.Text == "teacher")
            {
                MessageBox.Show("教师登陆成功");
            }
            else if (!rbtnTeacher.Checked && !rbtnStudent.Checked)
            {
                MessageBox.Show("请选择登陆用户身份");
            }
            else
            {
                MessageBox.Show("登陆失败，请检查后输入","错误提示");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            rbtnStudent.Checked=true;
        }
    }
}
