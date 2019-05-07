namespace team_development.UI.QueryGPA
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
            this.student_id = new System.Windows.Forms.Label();
            this.student_id_text = new System.Windows.Forms.TextBox();
            this.student_name = new System.Windows.Forms.Label();
            this.student_name_text = new System.Windows.Forms.TextBox();
            this.academic_year = new System.Windows.Forms.Label();
            this.choose_academic_year = new System.Windows.Forms.ComboBox();
            this.semester = new System.Windows.Forms.Label();
            this.choose_semester = new System.Windows.Forms.ComboBox();
            this.show_gpa = new System.Windows.Forms.ListView();
            this.validate = new System.Windows.Forms.Button();
            this.ShowValidate = new System.Windows.Forms.PictureBox();
            this.GetValide = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.getgpa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowValidate)).BeginInit();
            this.SuspendLayout();
            // 
            // student_id
            // 
            this.student_id.AutoSize = true;
            this.student_id.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.student_id.Location = new System.Drawing.Point(92, 38);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(39, 20);
            this.student_id.TabIndex = 0;
            this.student_id.Text = "学号";
            // 
            // student_id_text
            // 
            this.student_id_text.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.student_id_text.Location = new System.Drawing.Point(192, 35);
            this.student_id_text.Name = "student_id_text";
            this.student_id_text.Size = new System.Drawing.Size(120, 27);
            this.student_id_text.TabIndex = 1;
            this.student_id_text.Text = "2016052351";
            // 
            // student_name
            // 
            this.student_name.AutoSize = true;
            this.student_name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.student_name.Location = new System.Drawing.Point(433, 38);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(39, 20);
            this.student_name.TabIndex = 2;
            this.student_name.Text = "姓名";
            // 
            // student_name_text
            // 
            this.student_name_text.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.student_name_text.Location = new System.Drawing.Point(533, 35);
            this.student_name_text.Name = "student_name_text";
            this.student_name_text.Size = new System.Drawing.Size(120, 27);
            this.student_name_text.TabIndex = 3;
            this.student_name_text.Text = "lzp";
            // 
            // academic_year
            // 
            this.academic_year.AutoSize = true;
            this.academic_year.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.academic_year.Location = new System.Drawing.Point(95, 78);
            this.academic_year.Name = "academic_year";
            this.academic_year.Size = new System.Drawing.Size(39, 20);
            this.academic_year.TabIndex = 4;
            this.academic_year.Text = "学年";
            // 
            // choose_academic_year
            // 
            this.choose_academic_year.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choose_academic_year.FormattingEnabled = true;
            this.choose_academic_year.Items.AddRange(new object[] {
            "2015-2016",
            "2016-2017",
            "2017-2018",
            "2018-2019"});
            this.choose_academic_year.Location = new System.Drawing.Point(192, 78);
            this.choose_academic_year.Name = "choose_academic_year";
            this.choose_academic_year.Size = new System.Drawing.Size(120, 28);
            this.choose_academic_year.TabIndex = 5;
            // 
            // semester
            // 
            this.semester.AutoSize = true;
            this.semester.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.semester.Location = new System.Drawing.Point(433, 78);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(39, 20);
            this.semester.TabIndex = 6;
            this.semester.Text = "学期";
            // 
            // choose_semester
            // 
            this.choose_semester.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choose_semester.FormattingEnabled = true;
            this.choose_semester.Items.AddRange(new object[] {
            "上",
            "下"});
            this.choose_semester.Location = new System.Drawing.Point(532, 78);
            this.choose_semester.Name = "choose_semester";
            this.choose_semester.Size = new System.Drawing.Size(121, 28);
            this.choose_semester.TabIndex = 7;
            // 
            // show_gpa
            // 
            this.show_gpa.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.show_gpa.Location = new System.Drawing.Point(57, 140);
            this.show_gpa.Name = "show_gpa";
            this.show_gpa.Size = new System.Drawing.Size(832, 428);
            this.show_gpa.TabIndex = 8;
            this.show_gpa.UseCompatibleStateImageBehavior = false;
            this.show_gpa.SelectedIndexChanged += new System.EventHandler(this.Show_gpa_SelectedIndexChanged);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(943, 39);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(75, 23);
            this.validate.TabIndex = 9;
            this.validate.Text = "验证码";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // ShowValidate
            // 
            this.ShowValidate.Location = new System.Drawing.Point(789, 35);
            this.ShowValidate.Name = "ShowValidate";
            this.ShowValidate.Size = new System.Drawing.Size(100, 50);
            this.ShowValidate.TabIndex = 10;
            this.ShowValidate.TabStop = false;
            // 
            // GetValide
            // 
            this.GetValide.Location = new System.Drawing.Point(789, 109);
            this.GetValide.Name = "GetValide";
            this.GetValide.Size = new System.Drawing.Size(100, 25);
            this.GetValide.TabIndex = 11;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(533, 111);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 12;
            this.login.Text = "登陆";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // getgpa
            // 
            this.getgpa.Location = new System.Drawing.Point(192, 111);
            this.getgpa.Name = "getgpa";
            this.getgpa.Size = new System.Drawing.Size(75, 23);
            this.getgpa.TabIndex = 13;
            this.getgpa.Text = "查询";
            this.getgpa.UseVisualStyleBackColor = true;
            this.getgpa.Click += new System.EventHandler(this.getgpa_Click);
            // 
            // QueryMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 568);
            this.Controls.Add(this.getgpa);
            this.Controls.Add(this.login);
            this.Controls.Add(this.GetValide);
            this.Controls.Add(this.ShowValidate);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.show_gpa);
            this.Controls.Add(this.choose_semester);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.choose_academic_year);
            this.Controls.Add(this.academic_year);
            this.Controls.Add(this.student_name_text);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.student_id_text);
            this.Controls.Add(this.student_id);
            this.Name = "QueryMark";
            this.Text = "QueryMark";
            this.Load += new System.EventHandler(this.GpaInquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowValidate)).EndInit();
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
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.PictureBox ShowValidate;
        private System.Windows.Forms.TextBox GetValide;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button getgpa;
    }
}