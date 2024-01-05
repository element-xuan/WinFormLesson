using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.textBox1.ReadOnly = true;
            this.textBox2.ReadOnly = true;
        }

        private void RdoMan_CheckedChanged(object sender, System.EventArgs e)
        {
            //if (this.RdoMan.Checked == true)
            //{
            //    this.textBox1.Text = this.RdoMan.Text;
            //}
            //else
            //{

            //}
        }

        private void RdoWoman_CheckedChanged(object sender, System.EventArgs e)
        {
            //if (this.RdoWoman.Checked == true)
            //{
            //    this.textBox1.Text = this.RdoWoman.Text;
            //}
        }

        private void RdoMarred_CheckedChanged(object sender, System.EventArgs e)
        {
            //if (this.RdoMarred.Checked == true)
            //{
            //    this.textBox2.Text = this.RdoMarred.Text;
            //}
        }

        private void RdoSingle_CheckedChanged(object sender, System.EventArgs e)
        {
            //if (this.RdoSingle.Checked == true)
            //{
            //    this.textBox2.Text = this.RdoSingle.Text;
            //}
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (this.RdoMan.Checked == true)//性别男
            {
                this.textBox1.Text = this.RdoMan.Text;
            }
            else if (this.RdoWoman.Checked == true)//性别女
            {
                this.textBox1.Text = this.RdoWoman.Text;
            }

            if (this.RdoMarred.Checked == true)//已婚
            {
                this.textBox2.Text = this.RdoMarred.Text;
            }
            else if (this.RdoSingle.Checked == true)//未婚
            {
                this.textBox2.Text = this.RdoSingle.Text;
            }



            if (this.RdoMan.Checked == false && this.RdoWoman.Checked == false || this.RdoMarred.Checked == false && this.RdoSingle.Checked == false)
            {
                MessageBox.Show("请选择性别或婚姻状况");
                return;
            }
        }
    }
}
