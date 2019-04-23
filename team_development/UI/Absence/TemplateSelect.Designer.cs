namespace team_development.UI.Absence
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
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_templatePreview = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.textBox1.Location = new System.Drawing.Point(111, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(957, 35);
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
            this.listBox1.Location = new System.Drawing.Point(111, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(957, 334);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.btn_update.Location = new System.Drawing.Point(111, 494);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(199, 41);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "更新数据库";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_templatePreview
            // 
            this.btn_templatePreview.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.btn_templatePreview.Location = new System.Drawing.Point(356, 494);
            this.btn_templatePreview.Name = "btn_templatePreview";
            this.btn_templatePreview.Size = new System.Drawing.Size(199, 41);
            this.btn_templatePreview.TabIndex = 8;
            this.btn_templatePreview.Text = "预览";
            this.btn_templatePreview.UseVisualStyleBackColor = true;
            this.btn_templatePreview.Click += new System.EventHandler(this.btn_templatePreview_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.btn_confirm.Location = new System.Drawing.Point(615, 494);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(199, 41);
            this.btn_confirm.TabIndex = 9;
            this.btn_confirm.Text = "确认";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.btn_cancel.Location = new System.Drawing.Point(869, 494);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(199, 41);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // TemplateSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 682);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_templatePreview);
            this.Controls.Add(this.btn_update);
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
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_templatePreview;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
    }
}