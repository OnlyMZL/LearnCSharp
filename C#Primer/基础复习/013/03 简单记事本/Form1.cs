﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _03_简单记事本
{
    public partial class Form1 : Form
    {
        string str = "";  //声明字符串存储文本框中的内容
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            str = textBox1.Text;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "自动换行")
            {
                textBox1.WordWrap = true;
                button1.Text = "取消自动换行";
            }
            else
            {
                textBox1.WordWrap = false;
                button1.Text = "自动换行";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fsWrite = new FileStream(@"E:\C#\new.txt", FileMode.OpenOrCreate, FileAccess.Write);
            byte[] buffer = Encoding.Default.GetBytes(str);
            fsWrite.Write(buffer, 0, buffer.Length);
            MessageBox.Show("保存成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("登陆成功！");
                label1.Visible = false;
                label2.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                button3.Visible = false;
                button4.Visible = false;

                textBox1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入");
                textBox2.Clear();
                textBox3.Clear();
                textBox3.Focus();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Focus();
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox3.Focus();
        }
    }
}
