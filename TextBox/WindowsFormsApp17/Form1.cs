using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 属性
        //readonly 设置为只读
        private void label3_Click(object sender, EventArgs e)
        {
            this.textBox1.ReadOnly = true;
        }

        //enabled 启用文本框
        private void label4_Click(object sender, EventArgs e)
        {
            this.textBox2.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.textBox3.Multiline = true;
        }
        #endregion

        #region 事件
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("text属性被改变");
        }
        #endregion
    }
}
