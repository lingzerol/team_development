namespace team_development
{
    partial class AbsenceInput
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
            this.txt_selectedTemplate = new System.Windows.Forms.TextBox();
            this.btn_selectTemplate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_stuNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_autoComplete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_toName = new System.Windows.Forms.TextBox();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_wordPreview = new System.Windows.Forms.Button();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_startTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_endTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_selectedTemplate
            // 
            this.txt_selectedTemplate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.txt_selectedTemplate.Location = new System.Drawing.Point(111, 40);
            this.txt_selectedTemplate.Name = "txt_selectedTemplate";
            this.txt_selectedTemplate.Size = new System.Drawing.Size(694, 35);
            this.txt_selectedTemplate.TabIndex = 0;
            this.txt_selectedTemplate.Text = "学生标准请假条";
            this.txt_selectedTemplate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_selectTemplate
            // 
            this.btn_selectTemplate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.btn_selectTemplate.Location = new System.Drawing.Point(859, 38);
            this.btn_selectTemplate.Name = "btn_selectTemplate";
            this.btn_selectTemplate.Size = new System.Drawing.Size(227, 41);
            this.btn_selectTemplate.TabIndex = 1;
            this.btn_selectTemplate.Text = "浏览模板";
            this.btn_selectTemplate.UseVisualStyleBackColor = true;
            this.btn_selectTemplate.Click += new System.EventHandler(this.btn_selectTemplate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label1.Location = new System.Drawing.Point(108, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "学号";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.txt_name.Location = new System.Drawing.Point(238, 92);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(398, 35);
            this.txt_name.TabIndex = 3;
            this.txt_name.Text = "请假人姓名";
            // 
            // txt_department
            // 
            this.txt_department.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.txt_department.Location = new System.Drawing.Point(238, 137);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(398, 35);
            this.txt_department.TabIndex = 7;
            this.txt_department.Text = "请假人院系";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label3.Location = new System.Drawing.Point(108, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "姓名";
            // 
            // txt_stuNumber
            // 
            this.txt_stuNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.txt_stuNumber.Location = new System.Drawing.Point(238, 182);
            this.txt_stuNumber.Name = "txt_stuNumber";
            this.txt_stuNumber.Size = new System.Drawing.Size(398, 35);
            this.txt_stuNumber.TabIndex = 11;
            this.txt_stuNumber.Text = "请假人学号";
            this.txt_stuNumber.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label5.Location = new System.Drawing.Point(108, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "院系";
            // 
            // btn_autoComplete
            // 
            this.btn_autoComplete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.btn_autoComplete.Location = new System.Drawing.Point(110, 237);
            this.btn_autoComplete.Name = "btn_autoComplete";
            this.btn_autoComplete.Size = new System.Drawing.Size(976, 43);
            this.btn_autoComplete.TabIndex = 14;
            this.btn_autoComplete.Text = "自动填写";
            this.btn_autoComplete.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label7.Location = new System.Drawing.Point(108, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "请假对象";
            // 
            // txt_toName
            // 
            this.txt_toName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.txt_toName.Location = new System.Drawing.Point(238, 298);
            this.txt_toName.Name = "txt_toName";
            this.txt_toName.Size = new System.Drawing.Size(848, 35);
            this.txt_toName.TabIndex = 16;
            this.txt_toName.Text = "向谁请假，单位名，或是人(如李老师，暨南大学)";
            // 
            // txt_reason
            // 
            this.txt_reason.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.txt_reason.Location = new System.Drawing.Point(238, 354);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(848, 161);
            this.txt_reason.TabIndex = 17;
            this.txt_reason.Text = "请假理由";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label8.Location = new System.Drawing.Point(108, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "理由";
            // 
            // btn_wordPreview
            // 
            this.btn_wordPreview.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.btn_wordPreview.Location = new System.Drawing.Point(952, 543);
            this.btn_wordPreview.Name = "btn_wordPreview";
            this.btn_wordPreview.Size = new System.Drawing.Size(134, 38);
            this.btn_wordPreview.TabIndex = 19;
            this.btn_wordPreview.Text = "预览";
            this.btn_wordPreview.UseVisualStyleBackColor = true;
            this.btn_wordPreview.Click += new System.EventHandler(this.btn_wordPreview_Click);
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.txt_phoneNumber.Location = new System.Drawing.Point(824, 182);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(262, 35);
            this.txt_phoneNumber.TabIndex = 25;
            this.txt_phoneNumber.Text = "138147775";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label2.Location = new System.Drawing.Point(694, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "手机号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label4.Location = new System.Drawing.Point(694, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "结束时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label6.Location = new System.Drawing.Point(694, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "开始时间";
            // 
            // dtp_startTime
            // 
            this.dtp_startTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.dtp_startTime.Location = new System.Drawing.Point(824, 92);
            this.dtp_startTime.Name = "dtp_startTime";
            this.dtp_startTime.Size = new System.Drawing.Size(262, 35);
            this.dtp_startTime.TabIndex = 26;
            // 
            // dtp_endTime
            // 
            this.dtp_endTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.dtp_endTime.Location = new System.Drawing.Point(824, 137);
            this.dtp_endTime.Name = "dtp_endTime";
            this.dtp_endTime.Size = new System.Drawing.Size(262, 35);
            this.dtp_endTime.TabIndex = 27;
            // 
            // AbsenceInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 682);
            this.Controls.Add(this.dtp_endTime);
            this.Controls.Add(this.dtp_startTime);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_wordPreview);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.txt_toName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_autoComplete);
            this.Controls.Add(this.txt_stuNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_department);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_selectTemplate);
            this.Controls.Add(this.txt_selectedTemplate);
            this.Name = "AbsenceInput";
            this.Text = "填写请假条";
            this.Load += new System.EventHandler(this.Absence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_selectedTemplate;
        private System.Windows.Forms.Button btn_selectTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_stuNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_autoComplete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_toName;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_wordPreview;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_startTime;
        private System.Windows.Forms.DateTimePicker dtp_endTime;
    }
}