using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //标志位  卡流程
        //创建了三个标志位，当这三个状态都为true时，改变三个复选框控件的图标
        bool CheckBox1Sate = false;
        bool CheckBox2Sate = false;
        bool CheckBox3Sate = false;


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                CheckBox1Sate = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked == true)
            {
                CheckBox2Sate = true;
                CheckSate();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked == true)
            {
                CheckBox3Sate = true;
            }

            if (this.checkBox1.Checked == true && this.checkBox2.Checked == true && this.checkBox3.Checked == true)
            {
                MessageBox.Show("您的疫苗已经接种完毕！");
                this.checkBox1.CheckState = CheckState.Indeterminate;
                this.checkBox2.CheckState = CheckState.Indeterminate;
                this.checkBox3.CheckState = CheckState.Indeterminate;

                //将标志位 恢复为初始状态
                CheckBox1Sate = false;
                CheckBox2Sate = false;
                CheckBox3Sate = false;
            }
            else
            {
                MessageBox.Show("您的疫苗还未接种完毕！");
            }
        }


        void CheckSate(  )
        {
            if (this.checkBox1.Checked == true && this.checkBox2.Checked == true && this.checkBox3.Checked == true)
            {
                MessageBox.Show("您的疫苗已经接种完毕！");
                this.checkBox1.CheckState = CheckState.Indeterminate;
                this.checkBox2.CheckState = CheckState.Indeterminate;
                this.checkBox3.CheckState = CheckState.Indeterminate;

                //将标志位 恢复为初始状态
                CheckBox1Sate = false;
                CheckBox2Sate = false;
                CheckBox3Sate = false;
            }
            else
            {
                MessageBox.Show("您的疫苗还未接种完毕！");
            }

        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked)
            {
                MessageBox.Show("checkBox3 为点击状态");
            }
            else if (checkBox3.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("checkBox3 为未点击状态");
            }
            else if (checkBox3.CheckState == CheckState.Indeterminate) 
            {
                MessageBox.Show("checkBox3 为不确定状态");

            }
        }
    }
}
