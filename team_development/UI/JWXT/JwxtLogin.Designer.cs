namespace team_development.UI.JWXT
{
    partial class JwxtLogin
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
            this.Confirm = new System.Windows.Forms.Button();
            this.getValidate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ValidateImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ValidateImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Confirm.Location = new System.Drawing.Point(246, 232);
            this.Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(119, 32);
            this.Confirm.TabIndex = 8;
            this.Confirm.Text = "确认";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // getValidate
            // 
            this.getValidate.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getValidate.Location = new System.Drawing.Point(356, 149);
            this.getValidate.Name = "getValidate";
            this.getValidate.Size = new System.Drawing.Size(100, 31);
            this.getValidate.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "请输入验证码";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ValidateImage
            // 
            this.ValidateImage.Location = new System.Drawing.Point(169, 139);
            this.ValidateImage.Name = "ValidateImage";
            this.ValidateImage.Size = new System.Drawing.Size(114, 41);
            this.ValidateImage.TabIndex = 5;
            this.ValidateImage.TabStop = false;
            this.ValidateImage.Click += new System.EventHandler(this.ValidateImage_Click);
            // 
            // JwxtLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 306);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.getValidate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValidateImage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JwxtLogin";
            this.Text = "JwxtLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JwxtLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ValidateImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.TextBox getValidate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ValidateImage;
    }
}