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

        List<Student> ListStudent = new List<Student>();

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            #region 数据验证
            //非空验证
            if (this.TBUserName.Text.Trim() == "" || this.TBUserId.Text.Trim() == "")//判断TBUserName与 TBUserId 控件的文本值去除前后空格后是否为空
            {
                MessageBox.Show("用户名或密码为空");
                return;
            }
            #endregion

            #region 封装对象
            Student stu = new Student();
            stu.StudentName = this.TBUserName.Text;
            stu.StudentId = Convert.ToInt32(this.TBUserId.Text);
            #endregion

            //将封装的对象放入泛型集合中
            ListStudent.Add(stu);

            MessageBox.Show("添加成功");
            this.TBUserId.Text = "";
            this.TBUserName.Text = "";
        }

        private void BtnDataBinding_Click(object sender, EventArgs e)
        {
            this.listBox1.DataSource = null;

            //判断集合中是否添加了用户
            if (ListStudent.Count == 0)
            {
                MessageBox.Show("你还没有添加用户");
                return;
            }


            //清除文本
            this.listBox1.Items.Clear();
            //数据源绑定
            this.listBox1.DataSource = ListStudent;
            this.listBox1.DisplayMember = "StudentName";
        }
    }
}
