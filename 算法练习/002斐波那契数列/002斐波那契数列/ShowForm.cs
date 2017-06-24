using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002斐波那契数列
{
    public partial class ShowForm : Form
    {
        int[] n=new int[Tool.InputNum];
        public ShowForm()
        {
            InitializeComponent();
        }
        private void ShowForm_Load(object sender, EventArgs e)
        {
            Feb(Tool.InputNum);
        }

        public void Feb(int i)
        {
            if (i == 1)
            {
                txtShow.Text = 1.ToString();
                n[0] = 1;
            }
            else if(i==2)
            {
                txtShow.Text = "1,\n1";
            }
            else if(i>=3)
            {
                n[0] = 1;
                n[1] = 1;
                txtShow.Text = "1,\n1";
                for (int j = 3; j <= i ; j++)
                {
                    n[j-1] = n[j-2]+n[j-3];
                    txtShow.Text+=",\n"+n[j-1].ToString();
                }
            }
        }

        private void ShowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tool.F.Show();
            Tool.F.Focus();
        }
    }
}
