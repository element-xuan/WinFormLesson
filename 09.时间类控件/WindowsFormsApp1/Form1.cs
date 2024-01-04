using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.LabTime.Text = this.LabTime.Text + dateTime.ToString();
            //this.LabTime.Text += dateTime.ToString();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = this.dateTimePicker1.Text;



            string a = "2002-01-01";
            //a = this.dateTimePicker1.Text;

            this.dateTimePicker1.Text = a;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = this.dateTimePicker1.Text;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.textBox2.Text = this.monthCalendar1.SelectionStart.ToString();
        }
    }
}
