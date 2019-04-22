using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace team_development
{
    partial class Gpa_inquiry
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
            this.student_id = new System.Windows.Forms.Label();
            this.student_id_text = new System.Windows.Forms.TextBox();
            this.student_name = new System.Windows.Forms.Label();
            this.student_name_text = new System.Windows.Forms.TextBox();
            this.academic_year = new System.Windows.Forms.Label();
            this.choose_academic_year = new System.Windows.Forms.ComboBox();
            this.semester = new System.Windows.Forms.Label();
            this.choose_semester = new System.Windows.Forms.ComboBox();
            this.show_gpa = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // student_id
            // 
            this.student_id.AutoSize = true;
            this.student_id.Location = new System.Drawing.Point(92, 64);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(37, 15);
            this.student_id.TabIndex = 0;
            this.student_id.Text = "学号";
            // 
            // student_id_text
            // 
            this.student_id_text.Location = new System.Drawing.Point(192, 61);
            this.student_id_text.Name = "student_id_text";
            this.student_id_text.Size = new System.Drawing.Size(120, 25);
            this.student_id_text.TabIndex = 1;
            this.student_id_text.Text = "2016052351";
            // 
            // student_name
            // 
            this.student_name.AutoSize = true;
            this.student_name.Location = new System.Drawing.Point(433, 64);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(37, 15);
            this.student_name.TabIndex = 2;
            this.student_name.Text = "姓名";
            // 
            // student_name_text
            // 
            this.student_name_text.Location = new System.Drawing.Point(533, 61);
            this.student_name_text.Name = "student_name_text";
            this.student_name_text.Size = new System.Drawing.Size(120, 25);
            this.student_name_text.TabIndex = 3;
            this.student_name_text.Text = "lzp";
            // 
            // academic_year
            // 
            this.academic_year.AutoSize = true;
            this.academic_year.Location = new System.Drawing.Point(95, 130);
            this.academic_year.Name = "academic_year";
            this.academic_year.Size = new System.Drawing.Size(37, 15);
            this.academic_year.TabIndex = 4;
            this.academic_year.Text = "学年";
            // 
            // choose_academic_year
            // 
            this.choose_academic_year.FormattingEnabled = true;
            this.choose_academic_year.Items.AddRange(new object[] {
            "2015-2016",
            "2016-2017",
            "2017-2018",
            "2018-2019"});
            this.choose_academic_year.Location = new System.Drawing.Point(192, 122);
            this.choose_academic_year.Name = "choose_academic_year";
            this.choose_academic_year.Size = new System.Drawing.Size(120, 23);
            this.choose_academic_year.TabIndex = 5;
            // 
            // semester
            // 
            this.semester.AutoSize = true;
            this.semester.Location = new System.Drawing.Point(433, 122);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(37, 15);
            this.semester.TabIndex = 6;
            this.semester.Text = "学期";
            // 
            // choose_semester
            // 
            this.choose_semester.FormattingEnabled = true;
            this.choose_semester.Items.AddRange(new object[] {
            "上",
            "下"});
            this.choose_semester.Location = new System.Drawing.Point(532, 122);
            this.choose_semester.Name = "choose_semester";
            this.choose_semester.Size = new System.Drawing.Size(121, 23);
            this.choose_semester.TabIndex = 7;
            // 
            // show_gpa
            // 
            this.show_gpa.Location = new System.Drawing.Point(12, 163);
            this.show_gpa.Name = "show_gpa";
            this.show_gpa.Size = new System.Drawing.Size(1048, 440);
            this.show_gpa.TabIndex = 8;
            this.show_gpa.UseCompatibleStateImageBehavior = false;
            // 
            // Gpa_inquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 615);
            this.Controls.Add(this.show_gpa);
            this.Controls.Add(this.choose_semester);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.choose_academic_year);
            this.Controls.Add(this.academic_year);
            this.Controls.Add(this.student_name_text);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.student_id_text);
            this.Controls.Add(this.student_id);
            this.Name = "Gpa_inquiry";
            this.Text = "gpa_inquiry";
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
        private System.Windows.Forms.Label semester;
        private System.Windows.Forms.ComboBox choose_semester;
        private System.Windows.Forms.ListView show_gpa;
    }
}