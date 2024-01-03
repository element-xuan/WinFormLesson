namespace WindowsFormsApp14
{
    partial class FormMain
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
            this.BtnSayHi = new System.Windows.Forms.Button();
            this.BtnVisable = new System.Windows.Forms.Button();
            this.BtnGenderMen = new System.Windows.Forms.Button();
            this.BtnGenderChoose = new System.Windows.Forms.Button();
            this.BtnIsEnable = new System.Windows.Forms.Button();
            this.BtnGenderWomen = new System.Windows.Forms.Button();
            this.LabGender = new System.Windows.Forms.Label();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSayHi
            // 
            this.BtnSayHi.Location = new System.Drawing.Point(12, 12);
            this.BtnSayHi.Name = "BtnSayHi";
            this.BtnSayHi.Size = new System.Drawing.Size(115, 64);
            this.BtnSayHi.TabIndex = 0;
            this.BtnSayHi.Text = "HI";
            this.BtnSayHi.UseVisualStyleBackColor = true;
            this.BtnSayHi.Click += new System.EventHandler(this.BtnSayHi_Click);
            // 
            // BtnVisable
            // 
            this.BtnVisable.Location = new System.Drawing.Point(34, 194);
            this.BtnVisable.Name = "BtnVisable";
            this.BtnVisable.Size = new System.Drawing.Size(115, 64);
            this.BtnVisable.TabIndex = 1;
            this.BtnVisable.Text = "可见性";
            this.BtnVisable.UseVisualStyleBackColor = true;
            // 
            // BtnGenderMen
            // 
            this.BtnGenderMen.Location = new System.Drawing.Point(656, 30);
            this.BtnGenderMen.Name = "BtnGenderMen";
            this.BtnGenderMen.Size = new System.Drawing.Size(115, 64);
            this.BtnGenderMen.TabIndex = 2;
            this.BtnGenderMen.Text = "男";
            this.BtnGenderMen.UseVisualStyleBackColor = true;
            this.BtnGenderMen.Click += new System.EventHandler(this.BtnGenderMen_Click);
            // 
            // BtnGenderChoose
            // 
            this.BtnGenderChoose.Location = new System.Drawing.Point(487, 30);
            this.BtnGenderChoose.Name = "BtnGenderChoose";
            this.BtnGenderChoose.Size = new System.Drawing.Size(146, 121);
            this.BtnGenderChoose.TabIndex = 3;
            this.BtnGenderChoose.Text = "选择性别";
            this.BtnGenderChoose.UseVisualStyleBackColor = true;
            this.BtnGenderChoose.Click += new System.EventHandler(this.BtnGenderChoose_Click);
            // 
            // BtnIsEnable
            // 
            this.BtnIsEnable.Enabled = false;
            this.BtnIsEnable.Location = new System.Drawing.Point(34, 303);
            this.BtnIsEnable.Name = "BtnIsEnable";
            this.BtnIsEnable.Size = new System.Drawing.Size(115, 64);
            this.BtnIsEnable.TabIndex = 4;
            this.BtnIsEnable.Text = "可选性";
            this.BtnIsEnable.UseVisualStyleBackColor = true;
            // 
            // BtnGenderWomen
            // 
            this.BtnGenderWomen.Location = new System.Drawing.Point(656, 100);
            this.BtnGenderWomen.Name = "BtnGenderWomen";
            this.BtnGenderWomen.Size = new System.Drawing.Size(115, 64);
            this.BtnGenderWomen.TabIndex = 5;
            this.BtnGenderWomen.Text = "女";
            this.BtnGenderWomen.UseVisualStyleBackColor = true;
            this.BtnGenderWomen.Click += new System.EventHandler(this.BtnGenderWomen_Click);
            // 
            // LabGender
            // 
            this.LabGender.AutoSize = true;
            this.LabGender.Location = new System.Drawing.Point(333, 83);
            this.LabGender.Name = "LabGender";
            this.LabGender.Size = new System.Drawing.Size(67, 15);
            this.LabGender.TabIndex = 6;
            this.LabGender.Text = "性别为：";
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(323, 216);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(146, 121);
            this.BtnEnter.TabIndex = 7;
            this.BtnEnter.Text = "鼠标进入";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            this.BtnEnter.MouseEnter += new System.EventHandler(this.BtnEnter_MouseEnter);
            this.BtnEnter.MouseLeave += new System.EventHandler(this.BtnEnter_MouseLeave);
            // 
            // BtnLeave
            // 
            this.BtnLeave.Location = new System.Drawing.Point(508, 216);
            this.BtnLeave.Name = "BtnLeave";
            this.BtnLeave.Size = new System.Drawing.Size(146, 121);
            this.BtnLeave.TabIndex = 8;
            this.BtnLeave.Text = "鼠标离开";
            this.BtnLeave.UseVisualStyleBackColor = true;
            this.BtnLeave.Click += new System.EventHandler(this.BtnLeave_Click);
            this.BtnLeave.MouseLeave += new System.EventHandler(this.BtnLeave_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLeave);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.LabGender);
            this.Controls.Add(this.BtnGenderWomen);
            this.Controls.Add(this.BtnIsEnable);
            this.Controls.Add(this.BtnGenderChoose);
            this.Controls.Add(this.BtnGenderMen);
            this.Controls.Add(this.BtnVisable);
            this.Controls.Add(this.BtnSayHi);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSayHi;
        private System.Windows.Forms.Button BtnVisable;
        private System.Windows.Forms.Button BtnGenderMen;
        private System.Windows.Forms.Button BtnGenderChoose;
        private System.Windows.Forms.Button BtnIsEnable;
        private System.Windows.Forms.Button BtnGenderWomen;
        private System.Windows.Forms.Label LabGender;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnLeave;
    }
}

