using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharpDesktopDevelopment
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserName.Text!="123" || PassWord.Text != "123")
            {
                MessageBox.Show("错误");
                return;
            }
            // 通过类名调用静态变量
            MyClass.Instance.Name = UserName.Text;
            Form6 form6 = new Form6(UserName.Text,PassWord.Text);
            form6.Show();
            
            // 关闭登陆窗口
            this.Hide();

        }
    }
}
