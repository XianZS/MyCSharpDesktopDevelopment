namespace MyCSharpDesktopDevelopment
{
    partial class Form1
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
            this.MyButton1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ChoMan = new System.Windows.Forms.Button();
            this.ChoWoman = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // MyButton1
            // 
            this.MyButton1.Font = new System.Drawing.Font("宋体", 20F);
            this.MyButton1.Location = new System.Drawing.Point(268, 343);
            this.MyButton1.Name = "MyButton1";
            this.MyButton1.Size = new System.Drawing.Size(512, 87);
            this.MyButton1.TabIndex = 0;
            this.MyButton1.Text = "提交";
            this.MyButton1.UseVisualStyleBackColor = true;
            this.MyButton1.Click += new System.EventHandler(this.MyButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 20F);
            this.textBox1.Location = new System.Drawing.Point(268, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(512, 46);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "这是一个性别判断器";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ChoMan
            // 
            this.ChoMan.Font = new System.Drawing.Font("宋体", 30F);
            this.ChoMan.Location = new System.Drawing.Point(268, 161);
            this.ChoMan.Name = "ChoMan";
            this.ChoMan.Size = new System.Drawing.Size(161, 144);
            this.ChoMan.TabIndex = 2;
            this.ChoMan.Text = "男";
            this.ChoMan.UseVisualStyleBackColor = true;
            this.ChoMan.Click += new System.EventHandler(this.ChoMan_Click);
            // 
            // ChoWoman
            // 
            this.ChoWoman.Font = new System.Drawing.Font("宋体", 30F);
            this.ChoWoman.Location = new System.Drawing.Point(619, 161);
            this.ChoWoman.Name = "ChoWoman";
            this.ChoWoman.Size = new System.Drawing.Size(161, 144);
            this.ChoWoman.TabIndex = 3;
            this.ChoWoman.Text = "女";
            this.ChoWoman.UseVisualStyleBackColor = true;
            this.ChoWoman.Click += new System.EventHandler(this.ChoWoman_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 30F);
            this.button1.Location = new System.Drawing.Point(268, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 144);
            this.button1.TabIndex = 4;
            this.button1.Text = "是";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 30F);
            this.button2.Location = new System.Drawing.Point(619, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 144);
            this.button2.TabIndex = 5;
            this.button2.Text = "否";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(496, 225);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 15);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "链接";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 730);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChoWoman);
            this.Controls.Add(this.ChoMan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MyButton1);
            this.Name = "Form1";
            this.Text = "Form标题";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MyButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ChoMan;
        private System.Windows.Forms.Button ChoWoman;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}