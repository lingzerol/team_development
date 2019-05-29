using System;
using System.IO;
using System.Xml.Serialization;

namespace team_development.UI.UserInfo
{
    partial class UserInfoDisplay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StudentNumberTextBox = new System.Windows.Forms.TextBox();
            this.StudentNameTextBox = new System.Windows.Forms.TextBox();
            this.DormNumberTextBox = new System.Windows.Forms.TextBox();
            this.SZJDPasswordTextBox = new System.Windows.Forms.TextBox();
            this.JWXTPasswordTextBox = new System.Windows.Forms.TextBox();
            this.infochange = new System.Windows.Forms.Button();
            this.show_password = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(350, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(350, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(331, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "宿舍号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(293, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "校园卡密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(274, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "教务系统密码：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(135, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 154);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // StudentNumberTextBox
            // 
            this.StudentNumberTextBox.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.StudentNumberTextBox.Location = new System.Drawing.Point(443, 116);
            this.StudentNumberTextBox.Name = "StudentNumberTextBox";
            this.StudentNumberTextBox.Size = new System.Drawing.Size(312, 31);
            this.StudentNumberTextBox.TabIndex = 14;
            // 
            // StudentNameTextBox
            // 
            this.StudentNameTextBox.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.StudentNameTextBox.Location = new System.Drawing.Point(443, 168);
            this.StudentNameTextBox.Name = "StudentNameTextBox";
            this.StudentNameTextBox.Size = new System.Drawing.Size(312, 31);
            this.StudentNameTextBox.TabIndex = 15;
            // 
            // DormNumberTextBox
            // 
            this.DormNumberTextBox.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.DormNumberTextBox.Location = new System.Drawing.Point(443, 217);
            this.DormNumberTextBox.Name = "DormNumberTextBox";
            this.DormNumberTextBox.Size = new System.Drawing.Size(312, 31);
            this.DormNumberTextBox.TabIndex = 16;
            // 
            // SZJDPasswordTextBox
            // 
            this.SZJDPasswordTextBox.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.SZJDPasswordTextBox.Location = new System.Drawing.Point(443, 275);
            this.SZJDPasswordTextBox.Name = "SZJDPasswordTextBox";
            this.SZJDPasswordTextBox.PasswordChar = '*';
            this.SZJDPasswordTextBox.Size = new System.Drawing.Size(312, 31);
            this.SZJDPasswordTextBox.TabIndex = 18;
            // 
            // JWXTPasswordTextBox
            // 
            this.JWXTPasswordTextBox.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.JWXTPasswordTextBox.Location = new System.Drawing.Point(443, 330);
            this.JWXTPasswordTextBox.Name = "JWXTPasswordTextBox";
            this.JWXTPasswordTextBox.PasswordChar = '*';
            this.JWXTPasswordTextBox.Size = new System.Drawing.Size(312, 31);
            this.JWXTPasswordTextBox.TabIndex = 19;
            // 
            // infochange
            // 
            this.infochange.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infochange.Location = new System.Drawing.Point(552, 453);
            this.infochange.Name = "infochange";
            this.infochange.Size = new System.Drawing.Size(91, 37);
            this.infochange.TabIndex = 20;
            this.infochange.Text = "修改";
            this.infochange.UseVisualStyleBackColor = true;
            this.infochange.Click += new System.EventHandler(this.infochange_Click);
            // 
            // show_password
            // 
            this.show_password.AutoSize = true;
            this.show_password.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.show_password.Location = new System.Drawing.Point(443, 392);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(110, 29);
            this.show_password.TabIndex = 22;
            this.show_password.Text = "显示密码";
            this.show_password.UseVisualStyleBackColor = true;
            this.show_password.CheckedChanged += new System.EventHandler(this.show_password_CheckedChanged_1);
            // 
            // UserInfoDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1054, 568);
            this.Controls.Add(this.show_password);
            this.Controls.Add(this.infochange);
            this.Controls.Add(this.JWXTPasswordTextBox);
            this.Controls.Add(this.SZJDPasswordTextBox);
            this.Controls.Add(this.DormNumberTextBox);
            this.Controls.Add(this.StudentNameTextBox);
            this.Controls.Add(this.StudentNumberTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserInfoDisplay";
            this.Text = "用户信息";
            this.Load += new System.EventHandler(this.User1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox StudentNumberTextBox;
        private System.Windows.Forms.TextBox StudentNameTextBox;
        private System.Windows.Forms.TextBox DormNumberTextBox;
        private System.Windows.Forms.TextBox SZJDPasswordTextBox;
        private System.Windows.Forms.TextBox JWXTPasswordTextBox;
        private System.Windows.Forms.Button infochange;
        private System.Windows.Forms.CheckBox show_password;
    }
}