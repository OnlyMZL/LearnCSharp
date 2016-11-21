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

namespace _06_PictureBox
{
    public partial class Form1 : Form
    {
        static string[] _imgPath; //声明字段用于存储图片路径
        int i = 0;                //声明变量用于存储图片索引
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
                i = _imgPath.Length-1;
            }
            picImg.Image = Image.FromFile(_imgPath[i]);
            this.Text = "图片浏览器--" + _imgPath[i];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i++;
            if (i > _imgPath.Length-1)
            {
                i = 0;
            }
            picImg.Image = Image.FromFile(_imgPath[i]);
            this.Text = "图片浏览器--" + _imgPath[i];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _imgPath = Directory.GetFiles(@"E:\C#\Picture");
            picImg.Image = Image.FromFile(_imgPath[0]);
            picImg.SizeMode = PictureBoxSizeMode.Zoom;
            this.Text = "图片浏览器--" + _imgPath[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picImg.Image = Image.FromFile(_imgPath[r.Next(0, _imgPath.Length)]);
        }
    }
}
