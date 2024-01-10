namespace WindowsFormsApp16
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
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.TB4 = new System.Windows.Forms.TextBox();
            this.TB5 = new System.Windows.Forms.TextBox();
            this.TB6 = new System.Windows.Forms.TextBox();
            this.TB7 = new System.Windows.Forms.TextBox();
            this.TB8 = new System.Windows.Forms.TextBox();
            this.BtnResult = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB1
            // 
            this.TB1.Font = new System.Drawing.Font("宋体", 12F);
            this.TB1.Location = new System.Drawing.Point(12, 12);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(19, 30);
            this.TB1.TabIndex = 0;
            // 
            // TB2
            // 
            this.TB2.Font = new System.Drawing.Font("宋体", 12F);
            this.TB2.Location = new System.Drawing.Point(37, 12);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(19, 30);
            this.TB2.TabIndex = 1;
            // 
            // TB3
            // 
            this.TB3.Font = new System.Drawing.Font("宋体", 12F);
            this.TB3.Location = new System.Drawing.Point(62, 12);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(19, 30);
            this.TB3.TabIndex = 2;
            // 
            // TB4
            // 
            this.TB4.Font = new System.Drawing.Font("宋体", 12F);
            this.TB4.Location = new System.Drawing.Point(123, 12);
            this.TB4.Name = "TB4";
            this.TB4.Size = new System.Drawing.Size(19, 30);
            this.TB4.TabIndex = 3;
            // 
            // TB5
            // 
            this.TB5.Font = new System.Drawing.Font("宋体", 12F);
            this.TB5.Location = new System.Drawing.Point(148, 12);
            this.TB5.Name = "TB5";
            this.TB5.Size = new System.Drawing.Size(19, 30);
            this.TB5.TabIndex = 4;
            // 
            // TB6
            // 
            this.TB6.Font = new System.Drawing.Font("宋体", 12F);
            this.TB6.Location = new System.Drawing.Point(173, 12);
            this.TB6.Name = "TB6";
            this.TB6.Size = new System.Drawing.Size(19, 30);
            this.TB6.TabIndex = 5;
            // 
            // TB7
            // 
            this.TB7.Font = new System.Drawing.Font("宋体", 12F);
            this.TB7.Location = new System.Drawing.Point(198, 12);
            this.TB7.Name = "TB7";
            this.TB7.Size = new System.Drawing.Size(19, 30);
            this.TB7.TabIndex = 6;
            // 
            // TB8
            // 
            this.TB8.Font = new System.Drawing.Font("宋体", 12F);
            this.TB8.Location = new System.Drawing.Point(251, 12);
            this.TB8.Name = "TB8";
            this.TB8.Size = new System.Drawing.Size(189, 30);
            this.TB8.TabIndex = 7;
            // 
            // BtnResult
            // 
            this.BtnResult.Location = new System.Drawing.Point(12, 397);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(75, 41);
            this.BtnResult.TabIndex = 11;
            this.BtnResult.Text = "重置";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 133);
            this.button1.TabIndex = 12;
            this.button1.Text = "随机";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(699, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.TB8);
            this.Controls.Add(this.TB7);
            this.Controls.Add(this.TB6);
            this.Controls.Add(this.TB5);
            this.Controls.Add(this.TB4);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.TextBox TB4;
        private System.Windows.Forms.TextBox TB5;
        private System.Windows.Forms.TextBox TB6;
        private System.Windows.Forms.TextBox TB7;
        private System.Windows.Forms.TextBox TB8;
        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}

