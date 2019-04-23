namespace team_development.UI.InqueryInform
{

    struct Notification
    {
        string Title, PublishAgency, PublishDate;
        public Notification(string MyTitle, string MyPublishAgencty, string MyPublishDate)
        {
            Title = MyTitle;
            PublishAgency = MyPublishAgencty;
            PublishDate = MyPublishDate;
        }
    }

    partial class InquiryNotification
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
            this.dataGridViewNotifocation = new System.Windows.Forms.DataGridView();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPublishAgency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotifocation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 32F);
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "通知信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewNotifocation
            // 
            this.dataGridViewNotifocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNotifocation.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewNotifocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotifocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitle,
            this.ColumnPublishAgency,
            this.ColumnPublishDate});
            this.dataGridViewNotifocation.Location = new System.Drawing.Point(49, 114);
            this.dataGridViewNotifocation.Name = "dataGridViewNotifocation";
            this.dataGridViewNotifocation.RowTemplate.Height = 27;
            this.dataGridViewNotifocation.Size = new System.Drawing.Size(939, 395);
            this.dataGridViewNotifocation.TabIndex = 1;
            this.dataGridViewNotifocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.HeaderText = "标题";
            this.ColumnTitle.Name = "ColumnTitle";
            // 
            // ColumnPublishAgency
            // 
            this.ColumnPublishAgency.HeaderText = "发布单位";
            this.ColumnPublishAgency.Name = "ColumnPublishAgency";
            // 
            // ColumnPublishDate
            // 
            this.ColumnPublishDate.HeaderText = "发布日期";
            this.ColumnPublishDate.Name = "ColumnPublishDate";
            // 
            // InquiryNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 568);
            this.Controls.Add(this.dataGridViewNotifocation);
            this.Controls.Add(this.label1);
            this.Name = "InquiryNotification";
            this.Text = "InquiryNotification";
            this.Load += new System.EventHandler(this.InquiryNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotifocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNotifocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPublishAgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPublishDate;
    }
}