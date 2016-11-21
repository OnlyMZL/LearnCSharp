using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_ListBox控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] path = Directory.GetFiles(@"E:\C#\Picture", "*.jpg");
        private void Form1_Load(object sender, EventArgs e)
        {
            picb.Image =Image.FromFile(path[0]);
            picb.SizeMode = PictureBoxSizeMode.Zoom;
            foreach (var item in path)
            {
                lstb.Items.Add(Path.GetFileName(item));
            }
        }

        private void lstb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            picb.Image = Image.FromFile(path[lstb.SelectedIndex]);
        }
    }
}
