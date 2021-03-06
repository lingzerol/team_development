﻿namespace team_development.UI.QueryGPA
{
    partial class QueryMark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryMark));
            this.student_id = new System.Windows.Forms.Label();
            this.student_id_text = new System.Windows.Forms.TextBox();
            this.student_name = new System.Windows.Forms.Label();
            this.student_name_text = new System.Windows.Forms.TextBox();
            this.academic_year = new System.Windows.Forms.Label();
            this.choose_academic_year = new System.Windows.Forms.ComboBox();
            this.show_gpa = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // student_id
            // 
            this.student_id.AutoSize = true;
            this.student_id.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.student_id.Location = new System.Drawing.Point(52, 82);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(39, 20);
            this.student_id.TabIndex = 0;
            this.student_id.Text = "学号";
            // 
            // student_id_text
            // 
            this.student_id_text.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.student_id_text.Location = new System.Drawing.Point(107, 79);
            this.student_id_text.Name = "student_id_text";
            this.student_id_text.Size = new System.Drawing.Size(120, 27);
            this.student_id_text.TabIndex = 1;
            // 
            // student_name
            // 
            this.student_name.AutoSize = true;
            this.student_name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.student_name.Location = new System.Drawing.Point(288, 82);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(39, 20);
            this.student_name.TabIndex = 2;
            this.student_name.Text = "姓名";
            // 
            // student_name_text
            // 
            this.student_name_text.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.student_name_text.Location = new System.Drawing.Point(347, 79);
            this.student_name_text.Name = "student_name_text";
            this.student_name_text.Size = new System.Drawing.Size(120, 27);
            this.student_name_text.TabIndex = 3;
            // 
            // academic_year
            // 
            this.academic_year.AutoSize = true;
            this.academic_year.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.academic_year.Location = new System.Drawing.Point(514, 82);
            this.academic_year.Name = "academic_year";
            this.academic_year.Size = new System.Drawing.Size(75, 20);
            this.academic_year.TabIndex = 4;
            this.academic_year.Text = "学年-学期";
            // 
            // choose_academic_year
            // 
            this.choose_academic_year.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choose_academic_year.FormattingEnabled = true;
            this.choose_academic_year.Items.AddRange(new object[] {
            "ALL",
            "2015-2016，上",
            "2015-2016，下",
            "2016-2017，上",
            "2016-2017，下",
            "2017-2018，上",
            "2017-2018，下",
            "2018-2019，上",
            "2018-2019，下"});
            this.choose_academic_year.Location = new System.Drawing.Point(595, 78);
            this.choose_academic_year.Name = "choose_academic_year";
            this.choose_academic_year.Size = new System.Drawing.Size(191, 28);
            this.choose_academic_year.TabIndex = 5;
            this.choose_academic_year.SelectedIndexChanged += new System.EventHandler(this.choose_academic_year_SelectedIndexChanged);
            // 
            // show_gpa
            // 
            this.show_gpa.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.show_gpa.Location = new System.Drawing.Point(56, 128);
            this.show_gpa.Name = "show_gpa";
            this.show_gpa.Size = new System.Drawing.Size(944, 428);
            this.show_gpa.TabIndex = 8;
            this.show_gpa.UseCompatibleStateImageBehavior = false;
            this.show_gpa.SelectedIndexChanged += new System.EventHandler(this.Show_gpa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "查询成绩";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(249, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "GPA";
            // 
            // Refresh_button
            // 
            this.Refresh_button.FlatAppearance.BorderSize = 0;
            this.Refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_button.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Refresh_button.Image = ((System.Drawing.Image)(resources.GetObject("Refresh_button.Image")));
            this.Refresh_button.Location = new System.Drawing.Point(845, 40);
            this.Refresh_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(94, 66);
            this.Refresh_button.TabIndex = 1;
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // QueryMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 568);
            this.Controls.Add(this.Refresh_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show_gpa);
            this.Controls.Add(this.choose_academic_year);
            this.Controls.Add(this.academic_year);
            this.Controls.Add(this.student_name_text);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.student_id_text);
            this.Controls.Add(this.student_id);
            this.Name = "QueryMark";
            this.Text = "QueryMark";
            this.Load += new System.EventHandler(this.GpaInquiry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label student_id;
        private System.Windows.Forms.TextBox student_id_text;
        private System.Windows.Forms.Label student_name;
        private System.Windows.Forms.TextBox student_name_text;
        private System.Windows.Forms.Label academic_year;
        private System.Windows.Forms.ComboBox choose_academic_year;
        private System.Windows.Forms.ListView show_gpa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Refresh_button;
    }
}