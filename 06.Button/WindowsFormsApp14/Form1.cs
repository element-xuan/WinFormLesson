using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnSayHi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi!");
        }
        //点击选择性别后 将 男 女 按钮显示出来
        private void BtnGenderChoose_Click(object sender, EventArgs e)
        {
            this.BtnGenderMen.Visible = true;
            this.BtnGenderWomen.Visible = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.BtnGenderMen.Visible = false;
            this.BtnGenderWomen.Visible = false;
        }

        private void BtnGenderMen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("男");

            this.BtnGenderMen.Visible = false;
            this.BtnGenderWomen.Visible = false;

            this.LabGender.Text = this.LabGender.Text + "男";

            this.BtnGenderChoose.Enabled = false;
        }

        private void BtnGenderWomen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("女");

            this.BtnGenderMen.Visible = false;
            this.BtnGenderWomen.Visible = false;

            this.LabGender.Text = this.LabGender.Text + "女";

            this.BtnGenderChoose.Enabled = false;

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnter_MouseEnter(object sender, EventArgs e)
        {
            this.BtnEnter.BackColor = Color.Red;

        }

        private void BtnLeave_MouseLeave(object sender, EventArgs e)
        {
            this.BtnLeave.BackColor = Color.Yellow;

        }

        private void BtnEnter_MouseLeave(object sender, EventArgs e)
        {
            this.BtnEnter.BackColor = Color.White;
        }
    }
}
