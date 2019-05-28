namespace team_development.UI.Search
{
    partial class Search
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.choosetype = new System.Windows.Forms.ComboBox();
            this.showitem = new System.Windows.Forms.ListView();
            this.refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 25.8F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "学校新闻和通知";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(466, 14);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(208, 25);
            this.searchBox.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(696, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 25);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // choosetype
            // 
            this.choosetype.FormattingEnabled = true;
            this.choosetype.Items.AddRange(new object[] {
            "校内新闻",
            "校区公告",
            "讲座报告",
            "学生通知",
            "教师通知"});
            this.choosetype.Location = new System.Drawing.Point(339, 16);
            this.choosetype.Name = "choosetype";
            this.choosetype.Size = new System.Drawing.Size(121, 23);
            this.choosetype.TabIndex = 5;
            this.choosetype.Text = "校内新闻";
            this.choosetype.SelectedIndexChanged += new System.EventHandler(this.choosetype_SelectedIndexChanged);
            // 
            // showitem
            // 
            this.showitem.Location = new System.Drawing.Point(20, 66);
            this.showitem.Name = "showitem";
            this.showitem.Size = new System.Drawing.Size(751, 457);
            this.showitem.TabIndex = 6;
            this.showitem.UseCompatibleStateImageBehavior = false;
            this.showitem.SelectedIndexChanged += new System.EventHandler(this.showitem_SelectedIndexChanged);
            this.showitem.Click += new System.EventHandler(this.showitem_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(696, 43);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 7;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 568);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.showitem);
            this.Controls.Add(this.choosetype);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox choosetype;
        private System.Windows.Forms.ListView showitem;
        private System.Windows.Forms.Button refresh;
    }
}