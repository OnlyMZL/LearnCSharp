using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Label和TextBox
{
    public partial class Form1 : Form
    {
        string str = "☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "您输入的时间是：";
            label2.Text = "当前时间是：" + DateTime.Now.ToString();
            label3.Text = str;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "您输入的时间是：" + textBox1.Text;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "当前时间是：" + DateTime.Now.ToString();
            if (textBox1.Text==DateTime.Now.ToString())
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"E:\C#\music.wav";
                sp.Play();
            }

            str = str.Substring(1) + str.Substring(0, 1);
            label3.Text = str;
        }
    }
}
