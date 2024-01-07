using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 学生对象的泛型集合
        /// </summary>
        List<User> listUserIinfo = new List<User>();

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            //.....省略非空验证
            #region 封装对象
            User user = new User();
            user.UserName = this.TBUserName.Text;
            user.UserID = Convert.ToInt32(this.TBUserID.Text);
            #endregion
            listUserIinfo.Add(user);

            MessageBox.Show("添加成功！");

            //清空文本框控件内 text的值
            this.TBUserName.Text = "";
            this.TBUserID.Text = "";


            AddIten();
        }

        void AddIten()
        {
            this.comboBox1.DataSource = null;

            //数据绑定
            this.comboBox1.DataSource = listUserIinfo;
            this.comboBox1.DisplayMember = "UserName";


            //this.comboBox1.ValueMember = "UserID";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
        }
    }
}
