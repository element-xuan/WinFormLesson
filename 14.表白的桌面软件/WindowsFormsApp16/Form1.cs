using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            ResultNumber();
        }
        public void ResultNumber()
        {
            this.TB1.Text = "1";
            this.TB2.Text = "8";
            this.TB3.Text = "8";
            this.TB4.Text = "1";
            this.TB5.Text = "6";
            this.TB6.Text = "2";
            this.TB7.Text = "8";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResultNumber();
            this.TB8.Text = "0";
        }
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int a = random.Next(0, 10);
            int b = random.Next(0, 10);
            int c = random.Next(0, 10);
            int d = random.Next(0, 10);

            string LastNumber = Convert.ToString(a) + Convert.ToString(b) + Convert.ToString(c) + Convert.ToString(d);
            this.TB8.Text = LastNumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            Stream myStream;
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                }
            }
        }
    }
}
