using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharpDesktopDevelopment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 测试：实例化一个按钮
            // Button btn =new Button();
            // btn.Text = "Hello";
            // btn.Top = 10;
            // btn.Left = 10;
            // this.Controls.Add(btn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MyButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ChoMan_Click(object sender, EventArgs e)
        {
            MyButton1.Text = "已选中性别\"男\"，是否开始判断性别？";
        }

        private void ChoWoman_Click(object sender, EventArgs e)
        {
            MyButton1.Text = "正在判断中……";
            Thread.Sleep(3 * 1000);
            MyButton1.Text = "震惊，你原来不是人";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Thread.Sleep(3 * 1000);
            MyButton1.Text = "震惊，你原来不是人";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}