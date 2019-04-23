namespace team_development
{
    partial class TemplateSelect
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.textBox1.Location = new System.Drawing.Point(76, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(936, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "学生标准请假条";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Items.AddRange(new object[] {
            "学生标准请假条",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template"});
            this.listBox1.Location = new System.Drawing.Point(76, 133);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(936, 334);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.button2.Location = new System.Drawing.Point(76, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "更新数据库";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.button1.Location = new System.Drawing.Point(321, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "预览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.button3.Location = new System.Drawing.Point(571, 510);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "确认";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.button4.Location = new System.Drawing.Point(813, 510);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 41);
            this.button4.TabIndex = 10;
            this.button4.Text = "取消";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // TemplateSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 623);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "TemplateSelect";
            this.Text = "选择请假条模板";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}