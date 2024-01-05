namespace WindowsFormsApp1
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
            this.RdoMan = new System.Windows.Forms.RadioButton();
            this.RdoWoman = new System.Windows.Forms.RadioButton();
            this.RdoMarred = new System.Windows.Forms.RadioButton();
            this.RdoSingle = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RdoMan
            // 
            this.RdoMan.AutoSize = true;
            this.RdoMan.Location = new System.Drawing.Point(3, 3);
            this.RdoMan.Name = "RdoMan";
            this.RdoMan.Size = new System.Drawing.Size(43, 19);
            this.RdoMan.TabIndex = 0;
            this.RdoMan.Text = "男";
            this.RdoMan.UseVisualStyleBackColor = true;
            this.RdoMan.CheckedChanged += new System.EventHandler(this.RdoMan_CheckedChanged);
            // 
            // RdoWoman
            // 
            this.RdoWoman.AutoSize = true;
            this.RdoWoman.Location = new System.Drawing.Point(3, 28);
            this.RdoWoman.Name = "RdoWoman";
            this.RdoWoman.Size = new System.Drawing.Size(43, 19);
            this.RdoWoman.TabIndex = 1;
            this.RdoWoman.Text = "女";
            this.RdoWoman.UseVisualStyleBackColor = true;
            this.RdoWoman.CheckedChanged += new System.EventHandler(this.RdoWoman_CheckedChanged);
            // 
            // RdoMarred
            // 
            this.RdoMarred.AutoSize = true;
            this.RdoMarred.Location = new System.Drawing.Point(3, 3);
            this.RdoMarred.Name = "RdoMarred";
            this.RdoMarred.Size = new System.Drawing.Size(58, 19);
            this.RdoMarred.TabIndex = 2;
            this.RdoMarred.Text = "已婚";
            this.RdoMarred.UseVisualStyleBackColor = true;
            this.RdoMarred.CheckedChanged += new System.EventHandler(this.RdoMarred_CheckedChanged);
            // 
            // RdoSingle
            // 
            this.RdoSingle.AutoSize = true;
            this.RdoSingle.Location = new System.Drawing.Point(3, 28);
            this.RdoSingle.Name = "RdoSingle";
            this.RdoSingle.Size = new System.Drawing.Size(58, 19);
            this.RdoSingle.TabIndex = 3;
            this.RdoSingle.Text = "未婚";
            this.RdoSingle.UseVisualStyleBackColor = true;
            this.RdoSingle.CheckedChanged += new System.EventHandler(this.RdoSingle_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "婚姻状况：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(492, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RdoMan);
            this.panel1.Controls.Add(this.RdoWoman);
            this.panel1.Location = new System.Drawing.Point(117, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RdoMarred);
            this.panel2.Controls.Add(this.RdoSingle);
            this.panel2.Location = new System.Drawing.Point(407, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdoMan;
        private System.Windows.Forms.RadioButton RdoWoman;
        private System.Windows.Forms.RadioButton RdoMarred;
        private System.Windows.Forms.RadioButton RdoSingle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}

