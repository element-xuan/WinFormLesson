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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        //关闭当前窗口
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //string a = this.TBUserName.Text;//OUT：""

            #region 非空验证
            if (this.TBUserName.Text.Trim() == "")
            {
                MessageBox.Show("用户名未填写");
                return;
            }
            else if (this.TBPwd.Text.Trim() == "")
            {
                MessageBox.Show("密码未填写");
                return;
            }
            #endregion
            #region 用户名 密码 验证
            //声明两个string 类型的变量 作为用户名 以及密码
            string BaseUserName = "1";
            string BaseUserPwd = "1";

            #region 普通验证
            //判断 用户名是否正确
            //if (this.TBUserName.Text.Trim() == BaseUserName)
            //{

            //}
            //else
            //{
            //    MessageBox.Show("用户名不正确");
            //    return;
            //}
            //判断 密码是否正确
            //if (this.TBPwd.Text.Trim() == BaseUserPwd)
            //{

            //}
            //else
            //{
            //    MessageBox.Show("密码不正确");
            //    return;
            //}
            #endregion

            #region 对外来数据 或者 对用户  采取0信任策略
            if (this.TBUserName.Text.Trim() == BaseUserName && this.TBPwd.Text.Trim() == BaseUserPwd)
            {
               this.DialogResult =  DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
            #endregion
            #endregion
        }
    }
}
