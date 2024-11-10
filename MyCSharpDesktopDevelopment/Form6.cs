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
    public partial class Form6 : Form
    {
        public Form6(string UserName,string PassWord)
        {
            InitializeComponent();
            ShowName.Text = MyClass.Instance.Name;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 通知消息泵全部终止，并且在处理了所有的应用程序之后，关闭程序
            Application.Exit();
        }
    }
}
