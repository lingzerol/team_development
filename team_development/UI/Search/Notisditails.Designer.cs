namespace team_development.UI.Search
{
    partial class Notisditails
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
            this.notisdetails = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // notisdetails
            // 
            this.notisdetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notisdetails.Location = new System.Drawing.Point(0, 0);
            this.notisdetails.MinimumSize = new System.Drawing.Size(20, 20);
            this.notisdetails.Name = "notisdetails";
            this.notisdetails.Size = new System.Drawing.Size(1054, 568);
            this.notisdetails.TabIndex = 0;
            // 
            // Notisditails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 568);
            this.Controls.Add(this.notisdetails);
            this.Name = "Notisditails";
            this.Text = "Notisditails";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser notisdetails;
    }
}