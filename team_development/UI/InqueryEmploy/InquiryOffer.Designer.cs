namespace team_development.UI.InqueryEmploy
{
    partial class InquiryOffer
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
            this.dataGridViewOffer = new System.Windows.Forms.DataGridView();
            this.ColumnJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 32F);
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "就业信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewOffer
            // 
            this.dataGridViewOffer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOffer.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewOffer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnJob,
            this.ColumnSalary,
            this.ColumnCity,
            this.ColumnEducation});
            this.dataGridViewOffer.Location = new System.Drawing.Point(58, 87);
            this.dataGridViewOffer.Name = "dataGridViewOffer";
            this.dataGridViewOffer.RowTemplate.Height = 27;
            this.dataGridViewOffer.Size = new System.Drawing.Size(939, 395);
            this.dataGridViewOffer.TabIndex = 2;
            this.dataGridViewOffer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnJob
            // 
            this.ColumnJob.HeaderText = "职位";
            this.ColumnJob.Name = "ColumnJob";
            // 
            // ColumnSalary
            // 
            this.ColumnSalary.HeaderText = "薪水";
            this.ColumnSalary.Name = "ColumnSalary";
            // 
            // ColumnCity
            // 
            this.ColumnCity.HeaderText = "城市";
            this.ColumnCity.Name = "ColumnCity";
            // 
            // ColumnEducation
            // 
            this.ColumnEducation.HeaderText = "学历";
            this.ColumnEducation.Name = "ColumnEducation";
            // 
            // InquiryOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 568);
            this.Controls.Add(this.dataGridViewOffer);
            this.Controls.Add(this.label1);
            this.Name = "InquiryOffer";
            this.Text = "InquiryOffer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEducation;
    }
}