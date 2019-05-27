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
            this.Confirm.Location = new System.Drawing.Point(277, 278);
            this.Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(134, 38);
            this.Confirm.TabIndex = 8;
            this.Confirm.Text = "确认";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // getValidate
            // 
            this.getValidate.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getValidate.Location = new System.Drawing.Point(400, 179);
            this.getValidate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getValidate.Name = "getValidate";
            this.getValidate.Size = new System.Drawing.Size(112, 36);
            this.getValidate.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "请输入验证码";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ValidateImage
            // 
            this.ValidateImage.Location = new System.Drawing.Point(190, 167);
            this.ValidateImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValidateImage.Name = "ValidateImage";
            this.ValidateImage.Size = new System.Drawing.Size(128, 49);
            this.ValidateImage.TabIndex = 5;
            this.ValidateImage.TabStop = false;
            this.ValidateImage.Click += new System.EventHandler(this.ValidateImage_Click);
            // 
            // JwxtLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 367);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.getValidate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValidateImage);
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