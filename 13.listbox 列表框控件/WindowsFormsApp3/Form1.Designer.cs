namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.TBUserId = new System.Windows.Forms.TextBox();
            this.BtnDataBinding = new System.Windows.Forms.Button();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 424);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户ID：";
            // 
            // TBUserName
            // 
            this.TBUserName.Location = new System.Drawing.Point(606, 44);
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.Size = new System.Drawing.Size(171, 25);
            this.TBUserName.TabIndex = 3;
            // 
            // TBUserId
            // 
            this.TBUserId.Location = new System.Drawing.Point(606, 85);
            this.TBUserId.Name = "TBUserId";
            this.TBUserId.Size = new System.Drawing.Size(171, 25);
            this.TBUserId.TabIndex = 4;
            // 
            // BtnDataBinding
            // 
            this.BtnDataBinding.Location = new System.Drawing.Point(205, 193);
            this.BtnDataBinding.Name = "BtnDataBinding";
            this.BtnDataBinding.Size = new System.Drawing.Size(131, 98);
            this.BtnDataBinding.TabIndex = 5;
            this.BtnDataBinding.Text = "绑定数据";
            this.BtnDataBinding.UseVisualStyleBackColor = true;
            this.BtnDataBinding.Click += new System.EventHandler(this.BtnDataBinding_Click);
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(630, 125);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(128, 57);
            this.BtnAddUser.TabIndex = 6;
            this.BtnAddUser.Text = "添加用户";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.BtnDataBinding);
            this.Controls.Add(this.TBUserId);
            this.Controls.Add(this.TBUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.TextBox TBUserId;
        private System.Windows.Forms.Button BtnDataBinding;
        private System.Windows.Forms.Button BtnAddUser;
    }
}

