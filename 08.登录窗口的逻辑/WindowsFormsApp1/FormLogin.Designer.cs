namespace WindowsFormsApp1
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LabUserName = new System.Windows.Forms.Label();
            this.LabPwd = new System.Windows.Forms.Label();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.TBPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(156, 156);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "登录";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(302, 156);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "退出";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LabUserName
            // 
            this.LabUserName.AutoSize = true;
            this.LabUserName.Location = new System.Drawing.Point(35, 35);
            this.LabUserName.Name = "LabUserName";
            this.LabUserName.Size = new System.Drawing.Size(52, 15);
            this.LabUserName.TabIndex = 2;
            this.LabUserName.Text = "用户名";
            // 
            // LabPwd
            // 
            this.LabPwd.AutoSize = true;
            this.LabPwd.Location = new System.Drawing.Point(35, 107);
            this.LabPwd.Name = "LabPwd";
            this.LabPwd.Size = new System.Drawing.Size(45, 15);
            this.LabPwd.TabIndex = 3;
            this.LabPwd.Text = "密 码";
            // 
            // TBUserName
            // 
            this.TBUserName.Location = new System.Drawing.Point(156, 32);
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.Size = new System.Drawing.Size(221, 25);
            this.TBUserName.TabIndex = 4;
            // 
            // TBPwd
            // 
            this.TBPwd.Location = new System.Drawing.Point(156, 97);
            this.TBPwd.Name = "TBPwd";
            this.TBPwd.Size = new System.Drawing.Size(221, 25);
            this.TBPwd.TabIndex = 5;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 207);
            this.Controls.Add(this.TBPwd);
            this.Controls.Add(this.TBUserName);
            this.Controls.Add(this.LabPwd);
            this.Controls.Add(this.LabUserName);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LabUserName;
        private System.Windows.Forms.Label LabPwd;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.TextBox TBPwd;
    }
}