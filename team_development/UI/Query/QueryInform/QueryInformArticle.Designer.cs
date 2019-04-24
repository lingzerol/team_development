namespace team_development.UI.QueryInform
{
    partial class QueryInformArticle
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
            this.buttonNotification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 13F);
            this.textBox1.Location = new System.Drawing.Point(-6, -5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1056, 530);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // buttonNotification
            // 
            this.buttonNotification.Location = new System.Drawing.Point(470, 531);
            this.buttonNotification.Name = "buttonNotification";
            this.buttonNotification.Size = new System.Drawing.Size(88, 29);
            this.buttonNotification.TabIndex = 1;
            this.buttonNotification.Text = "返回";
            this.buttonNotification.UseVisualStyleBackColor = true;
            this.buttonNotification.Click += new System.EventHandler(this.button1_Click);
            // 
            // NotificationArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 568);
            this.Controls.Add(this.buttonNotification);
            this.Controls.Add(this.textBox1);
            this.Name = "NotificationArticle";
            this.Text = "NotificationArticle";
            this.Load += new System.EventHandler(this.NotificationArticle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonNotification;
    }
}